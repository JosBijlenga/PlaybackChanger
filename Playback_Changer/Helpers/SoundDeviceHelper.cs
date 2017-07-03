using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Playback_Changer.Helpers
{
    // https://github.com/DanStevens/AudioEndPointController
    public class SoundDeviceHelper
    {
        private const string FILE_LOCATION = "EPC.exe";

        public Eo.VisualDevice[] GetDevices()
        {

            try
            {
                var p = new Process
                {
                    StartInfo =
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        FileName = FILE_LOCATION,
                        Arguments = "-a -f \"%d|%ws|%d|%d|%ws|%ws|%ws\"" // Show all devices (inactive too) with detailed info
                    }
                };

                p.Start();
                p.WaitForExit();

                var stdout = p.StandardOutput.ReadToEnd().Trim();
                if (string.IsNullOrWhiteSpace(stdout))
                    throw new System.ComponentModel.Win32Exception(p.MainModule.ToString());

                int index = 1;
                var devices = new List<Eo.VisualDevice>();
                foreach (var line in stdout.Split('\n'))
                {
                    var elems = line.Trim().Split('|');
                    var state = (Eo.DeviceState)int.Parse(elems[2]);
                    var device = new Eo.VisualDevice(
                        (state == Eo.DeviceState.Active) ? index++ : -1,
                        elems[1],
                        state, int.Parse(elems[3]),
                        elems[4], elems[5], elems[6]
                        );
                    devices.Add(device);
                }

                return devices.ToArray();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                ExceptionHelper.TerminateWithMessage("One of the required files was missing {0x6403}. Try reinstalling the application");
                throw new Exception("0x6403");
            }
            catch (Exception)
            {
                ExceptionHelper.TerminateWithMessage("Something bad happened {0x3280}. I'm Sorry :(");
                throw new Exception("0x3280");
            }
        }

        /// <summary>
        /// Activate a device by ID to be the default playback device.
        /// </summary>
        /// <param name="index">The ID of the device to activate.</param>
        public bool DefaultDeviceByIndex(int index)
        {
            try
            {
                var p = new Process
                {
                    StartInfo =
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    FileName = FILE_LOCATION,
                    Arguments = index.ToString(CultureInfo.InvariantCulture)
                }
                };
                p.Start();
                p.WaitForExit();
                var stdout = p.StandardOutput.ReadToEnd().Trim();
                if (!string.IsNullOrWhiteSpace(stdout))
                    Console.WriteLine(stdout);
                return string.IsNullOrWhiteSpace(stdout);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                ExceptionHelper.TerminateWithMessage("One of the required files was missing {0x6403}. Try reinstalling the application");
                throw new Exception("0x6404");
            }
            catch (Exception)
            {
                ExceptionHelper.TerminateWithMessage("Something bad happened {0x3280}. I'm Sorry :(");
                throw new Exception("0x3281");
            }
        }

    }
}
