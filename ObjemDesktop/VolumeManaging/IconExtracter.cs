using System;
using System.Drawing;
using System.Runtime.InteropServices;
namespace ObjemDesktop.VolumeManaging
{
    class IconExtracter
    {
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, out IntPtr phiconLarge, out IntPtr phiconSmall, uint nIcons);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool DestroyIcon(IntPtr handle);

        private static readonly string DefaultIconPath = @"%SystemRoot%\System32\SHELL32.dll";
        private static readonly int DefaultIconIndex = 0;

        public static Icon Extract(String iconPath, int index)
        {
            try
            {
                IntPtr largeIconHandle = IntPtr.Zero;
                IntPtr _SmallIconHandle = IntPtr.Zero;
                //pathからアイコンを取得する
                IconExtracter.ExtractIconEx(iconPath, index, out largeIconHandle, out _SmallIconHandle, 1);
                Icon icon = (Icon)Icon.FromHandle(largeIconHandle).Clone();
                IconExtracter.DestroyIcon(largeIconHandle);
                IconExtracter.DestroyIcon(_SmallIconHandle);

                return icon;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public static Icon GetDefaultIcon()
        {
            return Extract(DefaultIconPath, DefaultIconIndex);
        }
    }
}