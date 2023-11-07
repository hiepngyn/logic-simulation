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
	/// Interaction logic for NorGateControl.xaml
	/// </summary>
	public partial class NorGateControl : UserControl
	{
		public NorGateControl()
		{
			InitializeComponent();
			NorGate n = new NorGate();
			this.DataContext = n;

			n.PropertyChanged += AndGatePropertyChange;
			TopInput.Fill = Brushes.Red;
			BottomInput.Fill = Brushes.Red;
			OutputValue.Fill = Brushes.Green;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TopInput_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			NorGate dataContext = this.DataContext as NorGate;
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
			NorGate dataContext = this.DataContext as NorGate;
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
			var a = DataContext as NorGate;
			TopInput.Fill = a.TopInput ? Brushes.Green : Brushes.Red;
			BottomInput.Fill = a.BottomInput ? Brushes.Green : Brushes.Red;
			OutputValue.Fill = a.OutputValue ? Brushes.Green : Brushes.Red;
		}
	}

}