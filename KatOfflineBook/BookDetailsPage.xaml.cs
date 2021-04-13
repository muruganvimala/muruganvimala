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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;

namespace Pro1
{
    /// <summary>
    /// Interaction logic for BookDetailsPage.xaml
    /// </summary>
    public partial class BookDetailsPage : Page
    {
        BookClass bc = new BookClass();
        
        public BookDetailsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {          
            
        }
        private void stackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.Timestamp - bc.lastClickTimestamp < 200)
           {
                //double click
           }
           bc.lastClickTimestamp = e.Timestamp;         
           
            Frame pageFrame = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && pageFrame == null)
            {
                pageFrame = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            // Change the page of the frame.
            if (pageFrame != null)
            {
                string subecjId = Regex.Replace(((System.Windows.FrameworkElement)sender).Name.ToString(),"name_","");

          ReadContentsPage bg = new ReadContentsPage(subecjId);
                pageFrame.Source = new Uri("ReadContentsPage.xaml", UriKind.Relative);
            }                   
        }

     
        private void Page_Initialized(object sender, EventArgs e)
        {
            string strStdDetails = ConfigurationManager.AppSettings["stdDetails"];
            string jsonFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"Assets\Data\Subjects.json");
            if (File.Exists(jsonFilePath))
            {
                var text = System.IO.File.ReadAllText(jsonFilePath);
                string json = File.ReadAllText(jsonFilePath);
                dynamic array = JsonConvert.DeserializeObject(json);
                var JsonResult = JsonConvert.DeserializeObject<List<SubjectClass>>(json);                
                foreach (var item in JsonResult)
                {
                    StackPanel sp = new StackPanel();
                    sp.Width = 150;
                    sp.Height = 200;
                    sp.Margin = new Thickness(10);
                    var margin = sp.Margin;
                    margin.Left = 10;                    
                    sp.Margin = margin;
                    sp.Name = "name_" + item._id;
                   
                    //label
                    TextBlock txtb = new TextBlock();
                    txtb.Text = item.variableName;
                    txtb.Name = "name_" + item._id;
                    txtb.FontSize = 15;
                    txtb.FontStyle = FontStyles.Normal;
                    txtb.FontWeight = FontWeights.SemiBold;
                    txtb.TextWrapping = TextWrapping.Wrap;                  
                                        
                    if (!string.IsNullOrEmpty(item.coverImage.Trim()))
                    {
                        //Image
                        var uriSource = new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"Assets\Data\Images\CoverImages\", item.coverImage));
                        BitmapImage btm = new BitmapImage(uriSource);
                        Image img = new Image();
                        img.Width = 150;
                        img.Height = 180;                     
                        img.Source = btm;
                        img.Stretch = Stretch.Fill;                       
                        sp.Children.Add(img);
                    }
                    sp.Children.Add(txtb);
                    sp.Margin = new System.Windows.Thickness(5, 0, 0, 0);
                    sp.Margin = new Thickness(5);
                    sp.MouseEnter += new MouseEventHandler(stackpanel_MouseEnter);
                   sp.MouseLeave += new MouseEventHandler(stackpanel_MouseLeave);
                    sp.MouseLeftButtonUp += new MouseButtonEventHandler(stackPanel_MouseLeftButtonUp);
                    bookdetailspanel.Children.Add(sp);                   
                }
                bookdetailspanel.UpdateLayout();
            }
            else
            {
                MessageBox.Show("File not found", "Katbook", MessageBoxButton.OK);
            }
        }


        private void stackpanel_MouseLeave(object sender, MouseEventArgs e)
        {
            StackPanel stackpanel = (StackPanel)sender;
            stackpanel.Background = Brushes.Transparent;
            if (this.Cursor != Cursors.Hand)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
            }
        }

        private void stackpanel_MouseEnter(object sender, MouseEventArgs e)
        {
            StackPanel stpanel = (StackPanel)sender;            
            //stackpanel.Background = Brushes.LightGray;
            var bc = new BrushConverter();
            stpanel.Background = (Brush)bc.ConvertFrom("#FF83C4EB");
            if (this.Cursor != Cursors.Arrow)
            {
                Mouse.OverrideCursor = Cursors.Hand;
            }
        }
    }

    public class SubjectClass
    {
        public string _id { get; set; }
        public string variableName { get; set; }
        public string coverImage { get; set; }
    }
}
