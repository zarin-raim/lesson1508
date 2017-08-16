using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCardSystemLibrary
{
    public class FullName
    {
        private string _firstName;
        private string _lastName;

        public FullName()
        {
            FirstName = "";
            LastName = "";
        }

        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
