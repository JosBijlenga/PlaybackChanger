using System;
using System.Collections.Generic;

namespace Playback_Changer.Eo
{
    public class HotkeySetting
    {
        public System.Windows.Forms.Keys Hotkey = System.Windows.Forms.Keys.None;
        public string Id = string.Empty;
    }

    public class HotkeySettingComparer : IEqualityComparer<HotkeySetting>
    {
        public bool Equals(HotkeySetting x, HotkeySetting y)
        {
            //Check whether the objects are the same object. 
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether the HotkeySetting's properties are equal. 
            return x != null && y != null && x.Hotkey.Equals(y.Hotkey) && x.Id.Equals(y.Id);
        }

        public int GetHashCode(HotkeySetting obj)
        {
            //Get hash code for the Id field if it is not null. 
            int hashProductName = obj.Id == null ? 0 : obj.Id.GetHashCode();

            //Get hash code for the Hotkey field. 
            int hashProductCode = obj.Hotkey.GetHashCode();

            //Calculate the hash code for the HotkeySetting. 
            return hashProductName ^ hashProductCode;
        }
    }
}
