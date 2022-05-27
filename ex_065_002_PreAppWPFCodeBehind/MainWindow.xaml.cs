// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : MainWindow.xaml.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-17
//
// ========================================================================

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

namespace ex_065_002_PreAppWPFCodeBehind
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "Incredible WPF Application";
            this.Height = 88;
            this.Width = 307;

            Button button1 = new Button();
            button1.Content = "Click me if you dare !";
            button1.Height = 26;
            button1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            button1.Margin = new Thickness(12, 12, 0, 0);
            button1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            button1.Width = 261;
            button1.Click += new RoutedEventHandler(button1_Click);

            this.Content = button1;
        }

        void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Oh... nasty little boy...", "You did it !");
        }
    }
}
