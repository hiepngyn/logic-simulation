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
    /// Interaction logic for PowerSupplyControl.xaml
    /// </summary>
    public partial class PowerSupplyControl : UserControl
    {
        public PowerSupplyControl()
        {
            InitializeComponent();
            PowerSupply p = new PowerSupply();
            this.DataContext = p;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerSupplyButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PowerSupply dataContext = this.DataContext as PowerSupply;
            if (dataContext != null)
            {
                dataContext.CurrentValue = !dataContext.CurrentValue;
            }
        }
    }
}
