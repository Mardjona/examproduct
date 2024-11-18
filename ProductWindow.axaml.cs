using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using productex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace productex1;

public partial class ProductWindow : Window
{
    public ProductWindow()
    {
        InitializeComponent();
        Productlist();


    }
    private void Productlist()
    {
        if (Search_TextBox == null) return;
        List<Product> products = Helper.Database.Products.ToList();

        if (!string.IsNullOrEmpty(Search_TextBox.Text))
        {
            products = products.Where(x => x.Productname.ToLower().Contains(Search_TextBox.Text.ToLower())).ToList();
        }
        ProductLisbox.ItemsSource = products.ToList();



    }

    public void ButtonExit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }
    private void TextBox_KeyUp(object? sender, KeyEventArgs keyEventArgs) => Productlist();
}