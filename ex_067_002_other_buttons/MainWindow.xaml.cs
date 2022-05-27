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
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ex_067_002_other_buttons
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

        int mEntierPourRepeatButton;

        private void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        {
            mEntierPourRepeatButton++;
            mTextBlockPourRepeatButton.Text = mEntierPourRepeatButton.ToString() ;
        }



        private void ToggleButton_Click_1(object sender, RoutedEventArgs e)
        {
            mTextBlockPourToggleButton.Text = string.Format("J'ai cliqué et l'état de mon ToggleButton est : IsChecked = {0}", 
                (sender as ToggleButton).IsChecked);
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            mTextBlockPourCheckBox.Text= string.Format("la checkBox est dans l'état : {0}", (sender as CheckBox).IsChecked.Value ? "checked" : "unchecked");
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            mTextBlockPourRadioButton.Text = (sender as RadioButton).Content.ToString();
        }
    }
}
