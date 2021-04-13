using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pro1
{
    /// <summary>
    /// Interaction logic for BookDetails.xaml
    /// </summary>
    public partial class BookContainer : Window
    {
        //private delegate void EmptyDelegate();
        private static readonly Action EmptyDelegate = delegate { };
                BookClass bc = new BookClass();
       
        public BookContainer()
        {
            bc.lastClickTimestamp = 1000;           
            
            InitializeComponent();
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            
            //this.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
            this.WindowState = WindowState.Maximized;
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            //this.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
        }

        private void minimizebtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void closebtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           BookDetailsPage bookpage = new BookDetailsPage();
          
           //ReadContentsPage bookpage = new ReadContentsPage();
            myframe.Content = bookpage;
            //Pro1.BookContainer.AppWindow.myframe.Content = bg;
            //Pro1.BookContainer.AppWindow.myframe.Refresh();
        }

       
    }
}
