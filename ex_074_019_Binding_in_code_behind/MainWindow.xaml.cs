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

namespace ex_074_019_Binding_in_code_behind
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nounours myNounours = new Nounours("Chucky", new DateTime(1988, 11, 9), 66);

            Binding mBindingNom = new Binding("Nom");
            mBindingNom.Source = myNounours;
            this.mTextBlockNom.SetBinding(TextBlock.TextProperty, mBindingNom);

            Binding mBindingNaissance = new Binding("DateDeNaissance");
            mBindingNaissance.Source = myNounours;
            this.mTextBlockNaissance.SetBinding(TextBlock.TextProperty, mBindingNaissance);

            Binding mBindingNbPoils = new Binding("NbPoils");
            mBindingNbPoils.Source = myNounours;
            BindingOperations.SetBinding(this.mTextBlockPoils, TextBlock.TextProperty, mBindingNbPoils);
        }
    }
}
