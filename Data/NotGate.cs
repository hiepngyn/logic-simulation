using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Class representing an NOT Gate object.
    /// </summary>
    public class NotGate : INotifyPropertyChanged
    {
        /// <summary>
        /// Name of the gate.
        /// </summary>
        public string Name = "NOT Gate";

        /// <summary>
        /// PropertyChangedHandler used whenever a property is needing to be updated.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Private backing for InputValue
        /// </summary>
        private bool _inputValue = false;

        /// <summary>
        /// Input value of a NOT gate.
        /// </summary>
        public bool InputValue
        {
            get => _inputValue;
            set
            {
                _inputValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OutputValue)));
            }
        }

        /// <summary>
        /// Output value of an AND gate.
        /// </summary>
        public bool OutputValue
        {
            get => !InputValue;
        }
    }
}
