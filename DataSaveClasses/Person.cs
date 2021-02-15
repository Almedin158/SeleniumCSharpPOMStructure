using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPractice.DataSaveClasses
{
    public class Person
    {
        string firstName = "Almedin";
        string lastName = "Alikadic";
        string email;
        string password = "Password123";
        int dayOfBirth = 15;
        int monthOfBirth = 8;
        int yearOfBirth = 1996;
        string company = "";
        string address = "Adema Buce 13";
        string addressLine2 = "";
        string city = "Sarajevo";
        int state=12;
        string postalCode = "71000";
        int country = 1;
        string additionalInformation = "";
        string homePhone = "";
        string mobilePhone = "+387603317627";
        string addressAlias = "Adema Buce 13, 71000 Sarajevo";
        public Person()
        {
            email = firstName + lastName + GenerateNumber() + "@gmail.com";
        }
        public string getEmail()
        {
            return email;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getPassword()
        {
            return password;
        }
        public int getDayOfBirth()
        {
            return dayOfBirth;
        }
        public int getMonthOfBirth()
        {
            return monthOfBirth;
        }
        public int getYearOfBirth()
        {
            return yearOfBirth;
        }
        public string getAddress()
        {
            return address;
        }
        public string getCity()
        {
            return city;
        }
        public int getState()
        {
            return state;
        }
        public string getPostalCode()
        {
            return postalCode;
        }
        public int getCountry()
        {
            return country;
        }
        public string getMobilePhone()
        {
            return mobilePhone;
        }
        public string getAddressAlias()
        {
            return addressAlias;
        }
        public string GenerateNumber()
        {
            var Numbers = "0123456789";
            var Random = new Random();
            var stringPhoneNumber = new char[3];
            for (int i = 0; i < stringPhoneNumber.Length; i++)
            {
                stringPhoneNumber[i] = Numbers[Random.Next(9)];
            }
            var GeneratedNumber = new String(stringPhoneNumber);
            return GeneratedNumber;
        }
    }
}
