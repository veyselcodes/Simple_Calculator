using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veysel_s_Calculator
{
    public class Result : INotifyPropertyChanged
    {
        private string num1;
        /*private string num2;
        private string result;*/

        public string Num1
        {
            get { return num1; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res)
                {
                    num1 = value;
                }
                OnPropertyChanged("Num1");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
