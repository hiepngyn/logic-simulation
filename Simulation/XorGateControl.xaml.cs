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
	/// Interaction logic for XorGateControl.xaml
	/// </summary>
	public partial class XorGateControl : UserControl
	{
		public XorGateControl()
		{
			InitializeComponent();
			XorGate n = new XorGate();
			this.DataContext = n;

			n.PropertyChanged += AndGatePropertyChange;
			TopInput.Fill = Brushes.Red;
			BottomInput.Fill = Brushes.Red;
			OutputValue.Fill = Brushes.Red;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TopInput_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			XorGate dataContext = this.DataContext as XorGate;
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
			XorGate dataContext = this.DataContext as XorGate;
			if (dataContext != null)
			{
				dataContext.BottomInput = !dataContext.BottomInput;
			}
		}

		private void AndGatePropertyChange(object? sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "TopInput" || e.PropertyName == "BottomInput" || e.PropertyName == "OutputValue") UpdateColor();
		}

		private void UpdateColor()
		{
			var a = DataContext as XorGate;
			TopInput.Fill = a.TopInput ? Brushes.Green : Brushes.Red;
			BottomInput.Fill = a.BottomInput ? Brushes.Green : Brushes.Red;
			OutputValue.Fill = a.OutputValue ? Brushes.Green : Brushes.Red;
		}
	}

}
