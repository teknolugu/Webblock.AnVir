using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Webblock_AV.Helper
{
    public static class ShellIcon
    {
        [DllImport("shell32.dll", EntryPoint = "ExtractIcon")]
        extern static IntPtr ExtractIcon(
            IntPtr hInst, string lpszExeFileName, int nIconIndex);
        const string ShellIconsLib = @"C:\WINDOWS\System32\shell32.dll";
        private const int Folder = 4;
        private const int HDD = 8;
        private const int RAM = 12;
        public static Icon GetIcon(int index)
        {
            IntPtr Hicon = ExtractIcon(IntPtr.Zero, ShellIconsLib, index);
            Icon icon = Icon.FromHandle(Hicon);
            return icon;
        }
    }
}
