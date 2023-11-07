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

namespace Simulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor of MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Current selected gate.
        /// </summary>
        private SelectedPart _currentSelection = SelectedPart.None;

        /// <summary>
        /// Enum to keep track of the selected gate
        /// </summary>
        private enum SelectedPart
        {
            None,
            AndGate,
            OrGate,
            NotGate,
            PowerSupply
        }


        /// <summary>
        /// Clicking on the canvas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_currentSelection != SelectedPart.None)
            {
                // Get the click position
                Point clickPosition = e.GetPosition(MainCanvas);

                // Create the gate control based on the selection
                UserControl gateControl = null;
                switch (_currentSelection)
                {
                    case SelectedPart.AndGate:
                        gateControl = new AndGateControl();
                        break;
                        // Handle other gate types similarly
                }

                if (gateControl != null)
                {
                    Canvas.SetLeft(gateControl, clickPosition.X);
                    Canvas.SetTop(gateControl, clickPosition.Y);
                    MainCanvas.Children.Add(gateControl);
                }

                // Reset the selection
                _currentSelection = SelectedPart.None;
            }
        }

        // Event handlers for gate buttons
        private void AndGateButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.AndGate;
        }

        private void PowerSupplyButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.PowerSupply;
        }
    }
}
