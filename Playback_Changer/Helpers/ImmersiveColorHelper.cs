using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Playback_Changer.Enums;

namespace Playback_Changer.Helpers
{
    public static class ImmersiveColorHelper
    {
        [DllImport("uxtheme.dll", EntryPoint = "#98", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        private static extern UInt32 GetImmersiveUserColorSetPreference(Boolean forceCheckRegistry, Boolean skipCheckOnFail);

        [DllImport("uxtheme.dll", EntryPoint = "#94", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        private static extern UInt32 GetImmersiveColorSetCount();

        [DllImport("uxtheme.dll", EntryPoint = "#95", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        private static extern UInt32 GetImmersiveColorFromColorSetEx(UInt32 immersiveColorSet, UInt32 immersiveColorType,
            Boolean ignoreHighContrast, UInt32 highContrastCacheMode);

        [DllImport("uxtheme.dll", EntryPoint = "#96", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        private static extern UInt32 GetImmersiveColorTypeFromName(IntPtr name);

        [DllImport("uxtheme.dll", EntryPoint = "#100", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        private static extern IntPtr GetImmersiveColorNamedTypeByIndex(UInt32 index);

        private static Color GetColor(IntPtr pElementName)
        {
            var colourset = GetImmersiveUserColorSetPreference(false, false);
            uint type = GetImmersiveColorTypeFromName(pElementName);
            Marshal.FreeCoTaskMem(pElementName);
            uint colourdword = GetImmersiveColorFromColorSetEx((uint)colourset, type, false, 0);
            byte[] colourbytes = new byte[4];
            colourbytes[0] = (byte)((0xFF000000 & colourdword) >> 24); // A
            colourbytes[1] = (byte)((0x00FF0000 & colourdword) >> 16); // B
            colourbytes[2] = (byte)((0x0000FF00 & colourdword) >> 8); // G
            colourbytes[3] = (byte)(0x000000FF & colourdword); // R
            Color color = Color.FromArgb(colourbytes[0], colourbytes[3], colourbytes[2], colourbytes[1]);
            return color;
        }

        public static Color GetColor(ImmersiveColors color)
        {
            IntPtr pElementName = Marshal.StringToHGlobalUni(color.ToString());
            return GetColor(pElementName);
        }
    }
}
