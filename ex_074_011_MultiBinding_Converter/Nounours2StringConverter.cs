// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours2StringConverter.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_074_011_MultiBinding_Converter
{
    [System.Windows.Data.ValueConversion(typeof(Nounours), typeof(string))]
    public class Nounours2StringConverter : System.Windows.Data.IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string nom = values[0] as string;
            DateTime dateDeNaissance = (DateTime)values[1];
            int nbPoils = (int)values[2];

            if (nbPoils < 100 && DateTime.Now - dateDeNaissance > TimeSpan.FromDays(365 * 20))
            {
                return string.Format("{0} est vieux et a perdu trop de poils, je n'en veux plus", nom);
            }
            else if (nbPoils < 100 && DateTime.Now - dateDeNaissance <= TimeSpan.FromDays(365 * 20))
            {
                return string.Format("{0} a beau n'avoir plus beaucoup de poils, il n'est pas si vieux, je le garde", nom);
            }
            else if (nbPoils >= 100 && DateTime.Now - dateDeNaissance > TimeSpan.FromDays(365 * 20))
            {
                return string.Format("{0} a beau être vieux, il a encore de beaux poils, je le garde", nom);
            }
            else //if (nbPoils >= 100 && DateTime.Now - dateDeNaissance <= TimeSpan.FromDays(365 * 20))
            {
                return string.Format("{0} est jeune et poilu, je le garde", nom);
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
