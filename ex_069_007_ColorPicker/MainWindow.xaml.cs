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

using Microsoft.Samples.CustomControls;
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

namespace ex_069_007_ColorPicker
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

        private void Rectangle_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            ColorPickerDialog cPicker = new ColorPickerDialog();
            Rectangle rectangle = sender as Rectangle;
            if (rectangle == null)
            {
                return;
            }

            cPicker.StartingColor = (rectangle.Fill as SolidColorBrush).Color;
            cPicker.Owner = this;

            bool? dialogResult = cPicker.ShowDialog();
            if (dialogResult != null && (bool)dialogResult == true)
            {
                rectangle.Fill = new SolidColorBrush(cPicker.SelectedColor);

                switch (rectangle.Name)
                {
                    case "mRectangleForeground":
                        mTextBlock.Foreground = new SolidColorBrush(cPicker.SelectedColor);
                        break;
                    case "mRectangleBackground":
                        mTextBlock.Background = new SolidColorBrush(cPicker.SelectedColor);
                        break;
                }
            }
        }
    }
}
