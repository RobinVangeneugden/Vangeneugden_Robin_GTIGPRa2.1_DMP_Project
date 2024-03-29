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
using Vangeneugden_Robin_DMP_Project_DAL;

namespace Vangeneugden_Robin_DMP_Project_WPF
{
    /// <summary>
    /// Interaction logic for AddDeleteGroep.xaml
    /// </summary>
    public partial class AddDeleteGroep: Window

    {

        private readonly MainWindow _mainWindow;
        private int _lidID;
        public AddDeleteGroep(MainWindow mainWindow, int lidID)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _lidID = lidID;  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblBandlid.Content = _mainWindow.cmbBandlid.Text;
            lbBandlid.ItemsSource = DatabaseOperations.OphalenGroepenVanBandlid(_lidID);
            lbGroepen.ItemsSource = DatabaseOperations.OphalenGroepen();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lbGroepen.SelectedItem != null)
            {
                DatabaseOperations.AddGroepVanBandlid(_lidID, ((Groep)lbGroepen.SelectedItem).id);
                lbBandlid.ItemsSource = DatabaseOperations.OphalenGroepenVanBandlid(_lidID);
                MessageBox.Show($"{((Groep)lbGroepen.SelectedItem).naam} is toegevoegd aan de lijst van {_mainWindow.cmbBandlid.Text}!", "Groep Toevoegen", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (lbBandlid.SelectedItem != null)
            {
                MessageBox.Show("Een groep uit deze lijst kan niet toegevoegd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer de toe te voegen groep!");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbBandlid.SelectedItem != null)
            {
                if (MessageBox.Show("Wil je deze groep uit de lijst verwijderen?", "Groep verwijderen?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    MessageBox.Show("Keep playing!");
                }
                else
                {
                    DatabaseOperations.DeleteGroepVanBandlid(_lidID, ((Groep)lbBandlid.SelectedItem).id);
                    MessageBox.Show($"{((Groep)lbBandlid.SelectedItem).naam} is succesvol verwijderd uit de lijst van {_mainWindow.cmbBandlid.Text}!", "Groep Verwijderd", MessageBoxButton.OK, MessageBoxImage.Information);
                    lbBandlid.ItemsSource = DatabaseOperations.OphalenGroepenVanBandlid(_lidID);
                }
            }
            else if (lbGroepen.SelectedItem != null)
            {
                MessageBox.Show("Een groep uit deze lijst kan niet verwijderd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer de te verwijderen groep!");
            }
        }
    }
}
