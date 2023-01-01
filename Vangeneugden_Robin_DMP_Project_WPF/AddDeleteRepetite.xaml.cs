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
    /// Interaction logic for AddDeleteRepetite.xaml
    /// </summary>
    public partial class AddDeleteRepetite : Window
    {
        private readonly MainWindow _mainWindow;
        private int _lidID;
        public AddDeleteRepetite(MainWindow mainWindow, int lidID)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _lidID = lidID;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblBandlid.Content = _mainWindow.cmbBandlid.Text;
            lbRepetitie.ItemsSource = DatabaseOperations.OphalenRepetities();
            lbBandlid.ItemsSource = DatabaseOperations.OphalenRepetitiesVanBandlid(_lidID);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lbRepetitie.SelectedItem != null)
            {
                DatabaseOperations.AddRepetitiesVanBandlid(_lidID, ((Repetitie)lbRepetitie.SelectedItem).id);
                lbBandlid.ItemsSource = DatabaseOperations.OphalenRepetitiesVanBandlid(_lidID);
                MessageBox.Show($"{((Repetitie)lbRepetitie.SelectedItem).omschrijving} is toegevoegd aan de lijst van {_mainWindow.cmbBandlid.Text}!", "Repetitie Toevoegen", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (lbBandlid.SelectedItem != null)
            {
                MessageBox.Show("Een repetitie uit deze lijst kan niet toegevoegd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer de toe te voegen repetitie!");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbBandlid.SelectedItem != null)
            {
                if (MessageBox.Show("Wil je de repetitie uit deze lijst verwijderen?", "Repetitie verwijderen?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    MessageBox.Show("Keep playing!");
                }
                else
                {
                    DatabaseOperations.DeleteRepetitieVanBandlid(_lidID, ((Repetitie)lbBandlid.SelectedItem).id);
                    MessageBox.Show($"{((Repetitie)lbBandlid.SelectedItem).omschrijving} is succesvol verwijderd uit de lijst van {_mainWindow.cmbBandlid.Text}!", "Repetitie Verwijderd", MessageBoxButton.OK, MessageBoxImage.Information);
                    lbBandlid.ItemsSource = DatabaseOperations.OphalenRepetitiesVanBandlid(_lidID);
                }
            }
            else if (lbRepetitie.SelectedItem != null)
            {
                MessageBox.Show("Een repetitie uit deze lijst kan niet verwijderd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer de te verwijderen repetitie!");
            }
        }
    }
}
