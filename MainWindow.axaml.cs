using Avalonia.Controls;
using System.Collections.Generic;

namespace productex1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }
        public void ButtonEnter_Click(object ? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
            this.Close();   
        }


    }
}