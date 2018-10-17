using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NonCompiledXaml
{
    public class Program:Application
    {
        [STAThread()]
        static void Main()
        {
            Program app = new Program();
            app.ShutdownMode = ShutdownMode.OnLastWindowClose;

            Window1 window1 = new Window1("Window2.xaml");
            window1.Show();

            Xaml2009Window window2 = Xaml2009Window.LoadWindowFromXaml("Xaml2009.xaml");
            window2.Show();

            app.Run();
        }
    }
}
