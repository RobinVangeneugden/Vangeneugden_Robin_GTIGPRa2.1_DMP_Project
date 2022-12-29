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
            List<Repetitie> repetitiesBandlid = DatabaseOperations.OphalenRepetitiesVanBandlid(_lidID);
            List<Repetitie> repetities = DatabaseOperations.OphalenRepetities();
            List<Locatie> locaties = DatabaseOperations.OphalenLocaties();

            foreach (Repetitie repetitie in repetitiesBandlid)
            {
                foreach (Locatie locatie in locaties)
                {
                    if (repetitie.locatieId == locatie.id)
                    {
                        lbBandlid.Items.Add(repetitie + " in " + locatie.naam + " te " + locatie.gemeente);
                    }

                }

            }

            foreach (Repetitie repetitie in repetities)
            {
                foreach (Locatie locatie in locaties)
                {
                    if (repetitie.locatieId == locatie.id)
                    {
                        lbRepetitie.Items.Add(repetitie + " in " + locatie.naam + " te " + locatie.gemeente);
                    }

                }

            }
        }
    }
}
