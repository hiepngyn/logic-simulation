using Data;
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
    /// Interaction logic for AndGateControl.xaml
    /// </summary>
    public partial class AndGateControl : UserControl
    {
        public AndGateControl()
        {
            InitializeComponent();
            AndGate a = new AndGate();
            this.DataContext = a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopInput_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AndGate dataContext = this.DataContext as AndGate;
            if (dataContext != null)
            {
                dataContext.TopInput = !dataContext.TopInput;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BottomInput_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AndGate dataContext = this.DataContext as AndGate;
            if (dataContext != null)
            {
                dataContext.BottomInput = !dataContext.BottomInput;
            }
        }
    }

}
