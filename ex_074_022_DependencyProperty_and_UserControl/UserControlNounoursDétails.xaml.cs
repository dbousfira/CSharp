// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : UserControlNounoursDétails.xaml.cs
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

namespace ex_074_022_DependencyProperty_and_UserControl
{
    /// <summary>
    /// Logique d'interaction pour UserControlNounoursDétails.xaml
    /// </summary>
    public partial class UserControlNounoursDétails : UserControl
    {
        public UserControlNounoursDétails()
        {
            InitializeComponent();
        }

        static UserControlNounoursDétails()
        {
            UserControlNounoursDétails.NomProperty = DependencyProperty.Register("Nom",
                typeof(string), typeof(UserControlNounoursDétails), 
                new PropertyMetadata("Babar"));
            UserControlNounoursDétails.NaissanceProperty = DependencyProperty.Register("Naissance",
                typeof(DateTime), typeof(UserControlNounoursDétails),
                new PropertyMetadata(new DateTime(1931, 1, 1)));
            UserControlNounoursDétails.PoilsProperty = DependencyProperty.Register("Poils",
                typeof(int), typeof(UserControlNounoursDétails),
                new PropertyMetadata(34));
        }

        public static readonly DependencyProperty NomProperty;
        public static readonly DependencyProperty NaissanceProperty;
        public static readonly DependencyProperty PoilsProperty;

        public string Nom
        {
            get
            {
                return GetValue(UserControlNounoursDétails.NomProperty) as string;
            }
            set
            {
                SetValue(UserControlNounoursDétails.NomProperty, value);
            }
        }

        public DateTime Naissance
        {
            get
            {
                return (DateTime)GetValue(UserControlNounoursDétails.NaissanceProperty);
            }
            set
            {
                SetValue(UserControlNounoursDétails.NaissanceProperty, value);
            }
        }

        public int Poils
        {
            get
            {
                return (int)GetValue(UserControlNounoursDétails.PoilsProperty);
            }
            set
            {
                SetValue(UserControlNounoursDétails.PoilsProperty, value);
            }
        }
    }
}
