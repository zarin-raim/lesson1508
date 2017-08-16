using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCardSystemLibrary
{
    public class Person
    {
        private IIN _iin;
        private PhoneNumber _phoneNumber;
        private FullName _fullName;

        public Person()
        {
            _iin = new IIN();
            _phoneNumber = new PhoneNumber();
            _fullName = new FullName();
        }
        public Person(string firstName, string lastName, string iin, string phoneNumber)
        {
            _fullName = new FullName(firstName, lastName);
            _iin = new IIN(iin);
            _phoneNumber = new PhoneNumber(phoneNumber);
        }
    }
}
