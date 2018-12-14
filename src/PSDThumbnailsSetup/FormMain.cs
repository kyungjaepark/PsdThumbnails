using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using PSDThumbnailsSetup.Properties;

namespace PSDThumbnailsSetup
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var args = Environment.GetCommandLineArgs();
            if (args.Length == 2 && args[1].ToLowerInvariant() == "/extract")
            {
                File.WriteAllBytes("PsdThumbnailProvider_x64.dll", Resources.PsdThumbnailProvider_x64);
                File.WriteAllBytes("PsdThumbnailProvider_x86.dll", Resources.PsdThumbnailProvider_x86);
                File.WriteAllBytes("psd-overlay.ico", Resources.PsdOverlayIcon_ico);
                Close();
                return;
            }
        }

        private string GetProgramRoot()
        {
            return Path.GetFullPath(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PsdThumbnails"));
        }

        private string GetDllPath()
        {
            return Path.GetFullPath(Path.Combine(GetProgramRoot(), "PsdThumbnailProvider.dll"));
        }

        private string GetIconPath()
        {
            return Path.GetFullPath(Path.Combine(GetProgramRoot(), "psd-overlay.ico"));
        }

        private void buttonPhotoshopSaver_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://kyungjaepark.com/photoshopsaver");
            Process.Start(sInfo);

        }

        private void linkLabelHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://kyungjaepark.com/psdthumbnails");
            Process.Start(sInfo);
        }

        private void buttonPreviewWithOverlay_Click(object sender, EventArgs e)
        {
            doInstall(true);
        }

        private void buttonPreviewNoOverlay_Click(object sender, EventArgs e)
        {
            doInstall(false);
        }

        private void doInstall(bool useOverlay)
        {
            if (Directory.Exists(GetProgramRoot()) == false)
                Directory.CreateDirectory(GetProgramRoot());

            bool isx64 = Environment.Is64BitOperatingSystem; // Wow.Is64BitOperatingSystem // in .NET 3.5
            byte[] dllSource = isx64 ? Resources.PsdThumbnailProvider_x64 : Resources.PsdThumbnailProvider_x86;
            try
            {
                File.WriteAllBytes(GetDllPath(), dllSource);
                File.WriteAllBytes(GetIconPath(), Resources.PsdOverlayIcon_ico);
            }
            catch
            {
                MessageBox.Show(
                    new StringBuilder()
                    .AppendLine("파일 복사 중 에러가 발생했습니다. 다음과 같이 진행해 보세요.")
                    .AppendLine()
                    .AppendLine("1. 설정 해제 를 눌러, 기존 미리보기 도구를 해제합니다.")
                    .AppendLine("2. 윈도에서 로그아웃한 후, 다시 로그인합니다.")
                    .AppendLine("3. 다시 설치를 시도합니다.")
                    .ToString()
                    , "복사 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            setOverlay(useOverlay);
            regsvr32(false);
            MessageBox.Show("설치가 완료되었습니다.");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            setOverlay(false);
            regsvr32(true);
            MessageBox.Show("해제가 완료되었습니다.");
        }

        private void setOverlay(bool useOverlay)
        {
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = @"cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = @"/c REG.EXE ADD HKCR\SystemFileAssociations\.psd /v ""TypeOverlay"" /d "" " + GetIconPath() + @""" /f";
            if (useOverlay == false)
                psi.Arguments = @"/c REG.EXE DELETE HKCR\SystemFileAssociations\.psd /v ""TypeOverlay"" /f";
            psi.RedirectStandardOutput = false;
            psi.CreateNoWindow = true;
            var x = Process.Start(psi);
            x.WaitForExit();

            // Notify Change on File Association
            SHChangeNotify((uint)0x08000000, (uint)0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        [DllImport("shell32.dll")]
        static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        private void regsvr32(bool isUnRegister)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"regsvr32.exe";
            psi.Arguments = (isUnRegister ? "/u " : "") + $" /s \"{GetDllPath()}\"";
            var p = Process.Start(psi);
            p.WaitForExit();
        }
    }
}
