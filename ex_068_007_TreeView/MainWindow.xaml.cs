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

namespace ex_068_007_TreeView
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

        private void TreeView_SelectedItemChanged_1(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var ancestors = new List<TreeViewItem>();
            TreeViewItem item = (sender as TreeView).SelectedItem as TreeViewItem;
            ancestors.Add(item);
            while (item.Parent is TreeViewItem)
            {
                item = item.Parent as TreeViewItem;
                ancestors.Insert(0, item);
            }
            StringBuilder result = ancestors.Select(it => it.Header.ToString()).Aggregate(new StringBuilder(), (sb, it) => sb.AppendFormat("{0}\\", it));
            mTextBlock.Text = string.Format("Vous avez sélectionné {0}", result.Remove(result.Length-1, 1).ToString());
        }
    }
}
