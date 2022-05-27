// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours2BoolConverter.cs
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
    [System.Windows.Data.ValueConversion(typeof(Nounours), typeof(bool))]
    public class Nounours2BoolConverter : System.Windows.Data.IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime dateDeNaissance = (DateTime)values[0];
            int nbPoils = (int)values[1];

            if (nbPoils < 100 && DateTime.Now - dateDeNaissance > TimeSpan.FromDays(365*20))
            {
                return false;
            }
            return true; 
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
