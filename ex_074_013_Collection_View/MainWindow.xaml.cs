// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : MainWindow.xaml.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
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

namespace ex_074_013_Collection_View
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Lit lit = new Lit();

            //mWindow.DataContext = lit;

            //NounoursView = new CollectionView(lit);

            //Binding mBindingNounoursView = new Binding();
            //mBindingNounoursView.Source = NounoursView;
            //BindingOperations.SetBinding(this.mListBox, ListBox.ItemsSourceProperty, mBindingNounoursView);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            System.ComponentModel.ICollectionView LitView = (mWindow.Resources["LitView"] as CollectionViewSource).View;

            switch (b.Name)
            {
                case "mButtonPrevious":
                    LitView.MoveCurrentToPrevious();

                    if (LitView.IsCurrentBeforeFirst)
                    {
                        LitView.MoveCurrentToLast();
                    }
                    break;

                case "mButtonNext":
                    LitView.MoveCurrentToNext();
                    if (LitView.IsCurrentAfterLast)
                    {
                        LitView.MoveCurrentToFirst();
                    }
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            string propertyName = "";
            System.ComponentModel.ListSortDirection sortDirection = System.ComponentModel.ListSortDirection.Ascending;

            switch (b.Name)
            {
                case "mButtonTriAlpha":
                    propertyName = "Nom";
                    sortDirection = System.ComponentModel.ListSortDirection.Ascending;
                    break;
                case "mButtonTriAlphaInv":
                    propertyName = "Nom";
                    sortDirection = System.ComponentModel.ListSortDirection.Descending;
                    break;
                case "mButtonTriNaissance":
                    propertyName = "DateDeNaissance";
                    sortDirection = System.ComponentModel.ListSortDirection.Ascending;
                    break;
                case "mButtonTriNaissanceInv":
                    propertyName = "DateDeNaissance";
                    sortDirection = System.ComponentModel.ListSortDirection.Descending;
                    break;
                case "mButtonTriPoils":
                    propertyName = "NbPoils";
                    sortDirection = System.ComponentModel.ListSortDirection.Ascending;
                    break;
                case "mButtonTriPoilsInv":
                    propertyName = "NbPoils";
                    sortDirection = System.ComponentModel.ListSortDirection.Descending;
                    break;

            }
            mListBox.Items.SortDescriptions.Clear();
            mListBox.Items.SortDescriptions.Add(
                new System.ComponentModel.SortDescription(propertyName, sortDirection));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.ComponentModel.ICollectionView LitView = (mWindow.Resources["LitView"] as CollectionViewSource).View;
            LitView.Filter = new Predicate<object>(n => (n as Nounours).NbPoils < 100);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.ComponentModel.ICollectionView LitView = (mWindow.Resources["LitView"] as CollectionViewSource).View;
            LitView.Filter = null;
        }
    }
}
