using System;
using System.Windows.Forms;

namespace Playback_Changer
{
    static class Program
    {
        private static System.Threading.Mutex _mutex;
        private static PlaybackChangerContext _context;

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                _mutex = new System.Threading.Mutex(true, "{TYORHV-5Q4HZ0-CYW6EJ-6XHL3I-IDT7C5}", out bool result);

                if (result)
                {
                    bool showNow = (args.Length == 0 || args[0] == "1");
                    _context = new PlaybackChangerContext(showNow);
                    Application.Run(_context);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                switch (e.Message)
                {
                    case "0x3280":
                    case "0x3281":
                    case "0x6403":
                    case "0x6404":
                        Console.WriteLine(e.Message);
                        Application.ExitThread();
                        break;
                    default: throw;
                }
            }
        }

        public static void Quit()
        {
            _context.ExitThread();
        }
    }
}
