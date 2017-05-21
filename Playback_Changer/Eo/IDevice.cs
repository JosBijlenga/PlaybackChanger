using System;
using System.Windows.Forms;

namespace Playback_Changer.Eo
{
    // https://msdn.microsoft.com/en-us/library/windows/desktop/dd370823(v=vs.85).aspx
    public enum DeviceState
    {
        Active = 1,
        Disabled = 2,
        NotPresent = 4,
        Unplugged = 8,
        MaskAll = 15
    }

    public interface IDevice : IComparable
    {

        #region Properties

        int Index
        {
            get;
            set;
        }

        string DeviceName
        {
            get;
            set;
        }

        DeviceState State
        {
            get;
            set;
        }

        bool Default
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        string InterfaceName
        {
            get;
            set;
        }

        string Id
        {
            get;
            set;
        }

        Keys Hotkey
        {
            get;
            set;
        }

        bool Ignored
        {
            get;
            set;
        }

        int SortOrder
        {
            get;
            set;
        }

        #endregion Properties

    }
}
