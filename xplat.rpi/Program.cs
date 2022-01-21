using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using System.Threading;
using System.Threading.Tasks;

namespace xplat.rpi
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args) {
            var builder = BuildAvaloniaApp();
            SilenceConsole();
            builder.StartLinuxDrm(args, scaling:1);
        }
        
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();

        private static void SilenceConsole()
        {
            new Thread(() => {
                Console.CursorVisible = false;
                while  (true)
                    Console.ReadKey(true);
            }) { IsBackground = true}.Start();
        }
    }
}
