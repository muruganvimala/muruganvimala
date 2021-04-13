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

namespace Pro1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void closebtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void textBox1_MouseEnter(object sender, MouseEventArgs e)
        {
            textBox1.BorderThickness = new Thickness(1, 1, 1, 3);
        }

        private void textBox1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (e.Equals(Mouse.LeftButton))

            {
                textBox1.BorderThickness = new Thickness(0, 0, 0, 1);
            }
            textBox1.BorderThickness = new Thickness(0, 0, 0, 1);
        }

        private void textBox2_MouseEnter(object sender, MouseEventArgs e)
        {
            textBox2.BorderThickness = new Thickness(1, 1, 1, 3);
        }

        private void textBox2_MouseLeave(object sender, MouseEventArgs e)
        {            
            if (e.Equals(Mouse.LeftButton))

            {
                textBox2.BorderThickness = new Thickness(0, 0, 0, 1);
            }
            textBox2.BorderThickness = new Thickness(0, 0, 0, 1);
        }

        private void passwordBox_MouseEnter(object sender, MouseEventArgs e)
        {
            passwordBox.BorderThickness = new Thickness(1, 1, 1, 3);
        }

        private void passwordBox_MouseLeave(object sender, MouseEventArgs e)
        {            
            if (e.Equals(Mouse.LeftButton))

            {
                passwordBox.BorderThickness = new Thickness(0, 0, 1, 1);
            }
            passwordBox.BorderThickness = new Thickness(0, 0, 0, 1);
        }

        private void textBox1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            textBox1.BorderThickness = new Thickness(1, 1, 1, 2);
        }

        private void textBox1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBox1.BorderThickness = new Thickness(1, 1, 1, 2);
        }

        private void textBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox1.BorderThickness = new Thickness(1, 1, 1, 2);
        }

        private void textBox1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBox1.BorderThickness = new Thickness(1, 1, 1, 2);
        }

        private void textBox2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBox2.BorderThickness = new Thickness(1, 1, 1, 2);
        }

        private void passwordBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            passwordBox.BorderThickness = new Thickness(1, 1, 1, 2);
        }

        private void minimizebtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void submitbtn_Click(object sender, RoutedEventArgs e)
        {
            BookContainer bd = new BookContainer();
            bd.Show();
            this.Hide();
        }
    }
}
