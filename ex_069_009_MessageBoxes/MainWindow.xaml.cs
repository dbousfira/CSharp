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

namespace ex_069_009_MessageBoxes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("un message pour ma MessageBox");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("un message pour ma MessageBox", "caption pour ma MessageBox");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("un message pour ma MessageBox", "caption pour ma MessageBox", MessageBoxButton.YesNoCancel);
            mTextBlockMessageBox3.Text = result.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("un message pour ma MessageBox", "caption pour ma MessageBox", MessageBoxButton.OKCancel);
            mTextBlockMessageBox4.Text = result.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBoxImage img = (MessageBoxImage)mComboBoxIcons.SelectedValue;
            MessageBoxResult result = MessageBox.Show("un message pour ma MessageBox", "caption pour ma MessageBox", MessageBoxButton.OKCancel, img);
            mTextBlockMessageBox5.Text = result.ToString();            
        }
    }
}
