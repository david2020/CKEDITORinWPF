using Microsoft.Win32;
using mshtml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        WebBrowser _webBrowser;

        public MainWindow()
        {
            InitializeComponent();

            string uri = AppDomain.CurrentDomain.BaseDirectory+"ckeditor\\samples\\index.html";
            this.browser.Navigate(new Uri(uri , UriKind.Absolute));
        }



        private void btnShow_Click(object sender , RoutedEventArgs e)
        {

            HTMLDocument document = (HTMLDocument)browser.Document;
            IHTMLElement editor = document.getElementById("cke_1_contents").children[0];


            MessageBox.Show(editor.innerHTML.ToString());
        }
    }
}