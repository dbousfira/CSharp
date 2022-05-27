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
using System.Windows.Threading;

namespace ex_069_005_Slider
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dt.Tick += dt_Tick;
            dt.Interval = TimeSpan.FromMilliseconds(100);
            dt.Start();
        }

        DispatcherTimer dt = new DispatcherTimer();

        void dt_Tick(object sender, EventArgs e)
        {
            mSlider.SelectionEnd += 0.1;
            mSlider.Value += 0.01;
            if (mSlider.Value >= mSlider.Maximum)
            {
                dt.Stop();
            }
        }

        private void mSlider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (mSlider.Value < mSlider.SelectionStart || mSlider.Value > mSlider.SelectionEnd)
            {
                dt.Stop();
                mSlider.SelectionStart = mSlider.Value;
                mSlider.SelectionEnd = mSlider.Value;
                dt.Start();
            }
            mSliderPosition.Text = string.Format("{0:0.00} / {1}", mSlider.Value, mSlider.Maximum);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (mSlider.Orientation == Orientation.Horizontal)
            {
                mSlider.Orientation = Orientation.Vertical;
                mSlider.Height = 500;
                mSlider.Width = 30;
                mStackPanel.Orientation = Orientation.Horizontal;
            }
            else
            {
                mSlider.Orientation = Orientation.Horizontal;
                mSlider.Width = 500;
                mSlider.Height = 30;
                mStackPanel.Orientation = Orientation.Vertical;
            }
        }
    }
}
