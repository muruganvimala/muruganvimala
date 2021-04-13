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
    /// Interaction logic for test1.xaml
    /// </summary>
    public partial class test1 : Window
    {
        //public test1()
        //{
        //    InitializeComponent();
        //}
        public test1()
        {
            InitializeComponent();
            List<Book> items = new List<Book>();
            
            items.Add(new Book() { subtopic = "Jane Doe", header = Department.head1.ToString() , chapterid="23444" });
            items.Add(new Book() { subtopic = "Sammy Doe", header = Department.head1.ToString(), chapterid = "23444" });
            items.Add(new Book() { subtopic = "John Doe", header = Department.head2.ToString(), chapterid = "23444" });
            lvEmps.ItemsSource = items;            
            
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvEmps.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("header");
            view.GroupDescriptions.Add(groupDescription);
        }
        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null )
            {
                //Do your stuff
                string chapterid = ((Pro1.Book)item.DataContext).chapterid;
            }
        }
    }
    //public enum SexType { Male, Female };
    public enum Department{ head1, head2 }
    public class Book
    {
        public string subtopic { get; set; }
        public string header { get; set; }
        public string chapterid { get; set; }

        //public SexType Sex { get; set; }
    }
}
