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
            NandGate,
            NorGate,
            XorGate,
            XnorGate,
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
                UserControl partControl = null;
                switch (_currentSelection)
                {
                    case SelectedPart.AndGate:
                        partControl = new AndGateControl();
                        break;     
                    case SelectedPart.OrGate:
                        partControl = new OrGateControl();
                        break;                    
                    case SelectedPart.NotGate:
                        partControl = new NotGateControl();
                        break;                    
                    case SelectedPart.NandGate:
                        partControl = new NandGateControl();
                        break;                    
                    case SelectedPart.NorGate:
                        partControl = new NorGateControl();
                        break;                    
                    case SelectedPart.XorGate:
                        partControl = new XorGateControl();
                        break;                    
                    case SelectedPart.XnorGate:
                        partControl = new XnorGateControl();
                        break;                 
                    case SelectedPart.PowerSupply:
                        partControl = new PowerSupplyControl();
                        break;
                }

                if (partControl != null)
                {
                    Canvas.SetLeft(partControl, clickPosition.X);
                    Canvas.SetTop(partControl, clickPosition.Y);
                    MainCanvas.Children.Add(partControl);
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
        
        private void OrGateButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.OrGate;
        }        
        
        private void NotGateButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.NotGate;
        }        
        
        private void NandGateButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.NandGate;
        }        
        
        private void NorGateButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.NorGate;
        }        
        
        private void XorGateButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.XorGate;
        }        
        
        private void XnorGateButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.XnorGate;
        }

        private void PowerSupplyButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.PowerSupply;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _currentSelection = SelectedPart.None;
            MainCanvas.Children.Clear();
        }
    }
}
