using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playback_Changer.Enums
{
    public class Constants
    {
        public static class UpdateType
        {
            public const string download = "download";
            public const string install = "install";
            public const string downloadRetry = "downloadRetry";
            public const string installRetry = "installRetry";
            public const string check = "check";
        }
    }
}
