using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Class representing Power Supply objects.
    /// </summary>
    public class PowerSupply : INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing for the name
        /// </summary>
        private string _name = "Power Supply";

        /// <summary>
        /// Name of the gate.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

        /// <summary>
        /// Property Changed Handler for when property changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Private backing field for current value
        /// </summary>
        private bool _currentValue = false;

        /// <summary>
        /// Current value of the power supply.
        /// </summary>
        public bool CurrentValue
        {
            get => _currentValue;
            set
            {
                _currentValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentValue)));
            }
        }
    }
}
