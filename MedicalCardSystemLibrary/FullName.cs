using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCardSystemLibrary
{
    public class FullName
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }

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
    }
}
