using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AndGate : INotifyPropertyChanged
    {
        public string Name = "AND Gate";

        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _topInput = false;

        public bool TopInput
        {
            get => _topInput;
            set
            {
                _topInput = value;

            }
        }     
        
        private bool _bottomInput = false;

        public bool BottomInput
        {
            get => _bottomInput;
            set
            {
                _bottomInput = value;

            }
        }

        private bool _outputValue = false;

        public bool OutputValue
        {
            get
            {
                if ((TopInput == true) && (BottomInput == true)) return true;
                else return false;
            }
        }

    }
}
