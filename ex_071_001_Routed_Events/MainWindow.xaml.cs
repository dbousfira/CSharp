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
using System.Diagnostics;
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

namespace ex_071_001_Routed_Events
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //button.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(button_MouseDown), true);
            //tocButton.AddHandler(Button.MouseDownEvent, new MouseButtonEventHandler(tocButton_MouseDown), true);
        }

        private void button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("button_MouseDown");
            mTextBlockResult.Text += "button_MouseDown\n";
        }
        private void button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("button_PreviewMouseDown");
            mTextBlockResult.Text += "button_PreviewMouseDown\n";

        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Grid_MouseDown");
            mTextBlockResult.Text += "Grid_MouseDown\n";

        }
        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Grid_PreviewMouseDown");
            mTextBlockResult.Text += "Grid_PreviewMouseDown\n";

        }
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Canvas_MouseDown");
            mTextBlockResult.Text += "Canvas_MouseDown\n";

        }
        private void Canvas_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Canvas_PreviewMouseDown");
            mTextBlockResult.Text += "Canvas_PreviewMouseDown\n";

        }
        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Ellipse_MouseDown");
            mTextBlockResult.Text += "Ellipse_MouseDown\n";

        }
        private void Ellipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Ellipse_PreviewMouseDown");
            mTextBlockResult.Text += "Ellipse_PreviewMouseDown\n";

        }

        private void tocButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("tocButton_MouseDown");
            mTextBlockResult.Text += "tocButton_MouseDown\n";

        }

        private void tocButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("tocButton_PreviewMouseDown");
            mTextBlockResult.Text += "tocButton_PreviewMouseDown\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("**************");
            mTextBlockResult.Text ="";

        }
    }
}
