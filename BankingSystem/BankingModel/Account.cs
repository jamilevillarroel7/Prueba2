using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {
        private string _name;
        private int _edad;
        //Si lees esto es porque está sincronizado
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }

        public Account()
        {

        }

        public Account(string name, int edad)
        {
            _name = name;
            _edad = edad;
        }


    }
}
