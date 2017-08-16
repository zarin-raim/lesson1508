using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCardSystemLibrary
{
    public class IIN
    {
        private string _number;
        private int _length;

        public IIN()
        {
            Length = 12;
            Number = "";
        }

        public IIN(string number)
        {
            Length = Length;
            Number = number;
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (Number.Length == Length)
                {
                    _number = value;
                }
                else
                {
                    _number = "";
                }
            }
        }
    }
}
