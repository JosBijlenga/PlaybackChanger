using System;
using System.Windows.Forms;

namespace Playback_Changer.Helpers
{
    public static class KeyHelper
    {
        public static bool IsAlphaKey(Keys key)
        {
            var name = key.ToString();
            if (name.Length != 1)
                return false;
            return Char.IsLetter(name[0]);
        }

        public static string KeysKeytoString(Keys? key)
        {
            if (!key.HasValue)
                return "null";
            var name = key.Value.ToString();
            if (name.Length < 0)
                return "error";
            else
                return (name.Length == 2) ? name.Substring(1) : name.Substring(0, 1);
        }

        public static Keys? StringToKeysKey(string key)
        {
            if (key.Length != 1)
                return null;
            if (char.IsNumber(key[0]))
                return (Keys)Enum.Parse(typeof(Keys), string.Format("D{0}", key[0]), true);
            if (char.IsLetter(key[0]))
                return (Keys)Enum.Parse(typeof(Keys), key.Substring(0, 1), true);
            return null;
        }

        public static bool IsValidKey(Keys key)
        {
            switch (key)
            {
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                    return true;
                default: break;
            }

            return IsAlphaKey(key);
        }

        public static Keys? MapIndexToKey(int index)
        {
            switch (index)
            {
                case 0: return Keys.F1;
                case 1: return Keys.F2;
                case 2: return Keys.F3;
                default: return null;
            }
        }
    }
}
