﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Class representing an NOR Gate object.
    /// </summary>
    public class NorGate : INotifyPropertyChanged
    {
        /// <summary>
        /// Name of the gate.
        /// </summary>
        public string Name = "NOR Gate";

        /// <summary>
        /// PropertyChangedHandler used whenever a property is needing to be updated.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Private backing for TopInput
        /// </summary>
        private bool _topInput = false;

        /// <summary>
        /// Top input value of an NOR gate.
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
        /// Bottom input value of an NOR gate.
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
        /// Output value of an NOR gate.
        /// </summary>
        public bool OutputValue
        {
            get
            {
                if ((TopInput == false) && (BottomInput == false)) return true;
                else return false;
            }
        }
    }
}
