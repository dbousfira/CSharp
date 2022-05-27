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

namespace ex_067_001_Button_Content
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Click += button1_Click2;
        }

        void button1_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("prout prout");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Oh... nasty little boy...", "You did it !");
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            mEllipse.Fill = Brushes.Bisque;
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            mEllipse.Fill = Brushes.BurlyWood;
        }

        private void button1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void button1_DragEnter_1(object sender, DragEventArgs e)
        {

        }

        private void button1_DragOver(object sender, DragEventArgs e)
        {

        }

    }
}
