// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : PlayerSettings.xaml.cs
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

namespace ex_072_001_UserControl
{
    /// <summary>
    /// Logique d'interaction pour PlayerSettings.xaml
    /// </summary>
    public partial class PlayerSettings : UserControl
    {
        public PlayerSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// la propriété Id de notre player settings qui set le texte lorsqu'elle est modifiée
        /// </summary>
        public int Id
        {
            get
            {
                return mId;
            }
            internal set
            {
                mId = value;
                mTextBlockPlayerId.Text = "Player " + mId.ToString();
            }
        }
        private int mId;

        /// <summary>
        /// une propriété qui permet de lire ou d'écrire un nom dans la textbox de notre player settings
        /// </summary>
        public string PlayerName
        {
            get
            {
                return mPlayerName;
            }
            internal set
            {
                mPlayerName = value;
                mTextBoxPlayerName.Text = mPlayerName;
            }
        }
        private string mPlayerName;
    }
}
