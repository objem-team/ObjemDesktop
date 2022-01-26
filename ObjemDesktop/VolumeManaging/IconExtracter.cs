using System;
using System.Drawing;
using System.Runtime.InteropServices;
namespace ObjemDesktop.VolumeManaging
{
    static class IconExtracter
    {
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        private static extern uint ExtractIconEx(string lpszFile, int nIconIndex, out IntPtr iconLarge, out IntPtr iconSmall, uint nIcons);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        private static readonly string DefaultIconPath = @"%SystemRoot%\System32\SHELL32.dll";
        private static readonly int DefaultIconIndex = 0;

        public static Icon Extract(String iconPath, int index)
        {
            try
            {
                //pathからアイコンを取得する
                ExtractIconEx(iconPath, index, out var largeIconHandle, out var smallIconHandle, 1);
                Icon icon = (Icon)Icon.FromHandle(largeIconHandle).Clone();
                DestroyIcon(largeIconHandle);
                DestroyIcon(smallIconHandle);

                return icon;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static Icon GetDefaultIcon()
        {
            return Extract(DefaultIconPath, DefaultIconIndex);
        }
    }
}