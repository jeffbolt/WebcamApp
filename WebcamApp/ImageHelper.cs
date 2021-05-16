using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WebcamApp
{
	public static class ImageHelper
	{
		[DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		private static extern int ExtractIconEx(string sFile, int iIndex, out IntPtr piLargeVersion, out IntPtr piSmallVersion, int amountIcons);

		public static Icon ExtractIcon(string file, int number, bool largeIcon)
		{
			// Ex: this.Icon = ImageHelper.ExtractIcon("shell32.dll", 42, true);
			ExtractIconEx(file, number, out IntPtr large, out IntPtr small, 1);
			try
			{
				return Icon.FromHandle(largeIcon ? large : small);
			}
			catch
			{
				return null;
			}
		}
	}
}
