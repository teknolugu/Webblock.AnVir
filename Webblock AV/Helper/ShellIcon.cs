using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Webblock_AV.Helper
{
    public static class ShellIcon
    {
        [DllImport("shell32.dll", EntryPoint = "ExtractIcon")]
        private static extern IntPtr ExtractIcon(
            IntPtr hInst, string lpszExeFileName, int nIconIndex);

        private const string ShellIconsLib = @"C:\WINDOWS\System32\shell32.dll";
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