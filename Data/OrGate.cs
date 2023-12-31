﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Class representing an OR Gate object.
    /// </summary>
    public class OrGate : INotifyPropertyChanged
    {
        /// <summary>
        /// Name of the gate.
        /// </summary>
        public string Name = "OR Gate";

        /// <summary>
        /// PropertyChangedHandler used whenever a property is needing to be updated.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Private backing for TopInput
        /// </summary>
        private bool _topInput = false;

        /// <summary>
        /// Top input value of an OR gate.
        /// </summary>
        public bool TopInput
        {
            get => _topInput;
            set
            {
                _topInput = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OutputValue)));
            }
        }

        /// <summary>
        /// Private backing for BottomInput
        /// </summary>
        private bool _bottomInput = false;

        /// <summary>
        /// Bottom input value of an OR gate.
        /// </summary>
        public bool BottomInput
        {
            get => _bottomInput;
            set
            {
                _bottomInput = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OutputValue)));
            }
        }

        /// <summary>
        /// Output value of an OR gate.
        /// </summary>
        public bool OutputValue
        {
            get
            {
                if ((TopInput == true) || (BottomInput == true)) return true;
                else return false;
            }
        }
    }
}
