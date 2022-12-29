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
    /// Interaction logic for AddDeleteConcert.xaml
    /// </summary>
    public partial class AddDeleteConcert : Window
    {
        private readonly MainWindow _mainWindow;
        private int _lidID;
        public AddDeleteConcert(MainWindow mainWindow, int lidID)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _lidID = lidID;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblBandlid.Content = _mainWindow.cmbBandlid.Text;
            List<Optreden> optredensBandlid = DatabaseOperations.OphalenOptredensVanBandlid(_lidID);
            List<Optreden> optredens = DatabaseOperations.OphalenOptredens();
            List<Locatie> locaties = DatabaseOperations.OphalenLocaties();

            foreach (Optreden optreden in optredensBandlid)
            {
                foreach (Locatie locatie in locaties)
                {
                    if (optreden.locatieId == locatie.id)
                    {
                        lbBandlid .Items.Add(optreden + " in " + locatie.naam + " te " + locatie.gemeente);
                    }

                }

            }

            foreach (Optreden optreden in optredens)
            {
                foreach (Locatie locatie in locaties)
                {
                    if (optreden.locatieId == locatie.id)
                    {
                        lbConcert.Items.Add(optreden + " in " + locatie.naam + " te " + locatie.gemeente);
                    }
                    
                }
                
            }
        }
    }
}
