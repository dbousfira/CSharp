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

namespace ex_072_001_UserControl
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            //ajout des deux player settings par défaut qui ont été ajoutés dans le xaml, dans notre liste privée
            mPlayerSettingsList.AddRange(new PlayerSettings[] { mPlayerSettings1, mPlayerSettings2 });
        }

        /// <summary>
        /// liste privée de l'ensemble des player settings qu'il y a dans la fenêtre
        /// </summary>
        List<PlayerSettings> mPlayerSettingsList = new List<PlayerSettings>();

        /// <summary>
        /// méthode appelée quand le bouton "+" est cliqué : ajoute un player settings dynamiquement dans la fenêtre
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //on crée un nouveau player settings
            PlayerSettings pSettings = new PlayerSettings();
            //on incrémente l'identifiant pour lui donner la bonne valeur
            pSettings.Id = mPlayerSettingsList.Count + 1;
            pSettings.PlayerName = mNames[(pSettings.Id - 1) % mNames.Length];
            //on ajoute quelques propriétés
            pSettings.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            pSettings.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            //on ajoute une nouvelle ligne à la grille
            mPlayerSettingsGrid.RowDefinitions.Add(new RowDefinition());
            //on ajoute le player settings à la grille en le plaçant sur la nouvelle ligne
            mPlayerSettingsGrid.Children.Add(pSettings);
            pSettings.SetValue(Grid.RowProperty, pSettings.Id);
            pSettings.SetValue(Grid.ColumnSpanProperty, 4);

            //on ajoute notre player settings à la liste privée
            mPlayerSettingsList.Add(pSettings);
        }

        /// <summary>
        /// méthode appelée quand le "-" est cliqué (on enlève un player settings dynamiquement)
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //on vérife qu'il reste des player settings
            int nb = mPlayerSettingsList.Count;
            if (nb == 0)
            {
                return;
            }

            //on récupère la référence du dernier playersettings
            PlayerSettings pSettings = mPlayerSettingsList.ElementAt(nb - 1);

            //on le retire de la grille
            mPlayerSettingsGrid.Children.Remove(pSettings);
            //on enlève la dernière ligne de la grille
            mPlayerSettingsGrid.RowDefinitions.RemoveAt(nb);
            //on retire le player settings de la liste privée
            mPlayerSettingsList.RemoveAt(nb - 1);
        }

        static string[] mNames = new string[] { "Dwight Schrute", "Michael Scott", "Jim Raynor", "Sheldon Cooper", "Leonard Hofstadter" };
    }
}
