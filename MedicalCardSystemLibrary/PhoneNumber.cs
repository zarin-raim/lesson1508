using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCardSystemLibrary
{
    public class PhoneNumber
    {
        private string _number;

        public PhoneNumber()
        {
            Number = "";
        }

        public PhoneNumber(string number)
        {
            Number = number;
        }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                foreach(char symbol in value)
                {
                    bool isNums = true;
                    if (symbol < 48 || symbol > 57)
                        isNums = false;

                    if (isNums)
                        _number = value;
                    else
                        _number = "";
                }
            }
        }
    }
}
