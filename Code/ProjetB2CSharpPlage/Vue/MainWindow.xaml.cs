﻿using System;
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
using ProjetB2CSharpPlage.Vue;
using System.Collections.ObjectModel;

namespace ProjetB2CSharpPlage
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Page AfficherUtilisateurs = new AfficherUtilisateurs();
            Page AfficherZonePrelevements = new AfficherZonePrelevements();
            this.Content = AfficherZonePrelevements;
        }
    }
}