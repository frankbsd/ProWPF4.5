using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace NonCompiledXaml
{
    public class Window1  : Window
    {
        private Button  button1;

        public Window1(string xamlFile)
        {
            InitializeComponent(xamlFile);
        }

        private void InitializeComponent(string xamlFile)
        {
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML";

            DependencyObject rootElement;
            using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }

            this.Content = rootElement;

            FrameworkElement frameworkElement = (FrameworkElement)rootElement;
            button1 = (Button)frameworkElement.FindName("button1");

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Thank you";
        }
    }
}
