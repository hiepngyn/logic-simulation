using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	/// Interaction logic for NotGateControl.xaml
	/// </summary>
	public partial class NotGateControl : UserControl
	{
		public NotGateControl()
		{
			InitializeComponent();
			NotGate n = new NotGate();
			this.DataContext = n;

			n.PropertyChanged += AndGatePropertyChange;
			InputValue.Fill = Brushes.Red;
			OutputValue.Fill = Brushes.Green;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Input_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			NotGate dataContext = this.DataContext as NotGate;
			if (dataContext != null)
			{
				dataContext.InputValue = !dataContext.InputValue;
			}
		}


		private void AndGatePropertyChange(object? sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "TopInput" || e.PropertyName == "BottomInput" || e.PropertyName == "OutputValue") UpdateColor();
		}

		private void UpdateColor()
		{
			var n = DataContext as NotGate;
			InputValue.Fill = n.InputValue ? Brushes.Green : Brushes.Red;
			OutputValue.Fill = n.OutputValue ? Brushes.Green : Brushes.Red;
		}
	}

}
