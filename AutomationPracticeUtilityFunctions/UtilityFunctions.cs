using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.AutomationPracticeUtilityFunctions
{
    class UtilityFunctions
    {

        public string GenerateFirstName()
        {
            var FirstLetter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var SmallLetters = "abcdefghijklmnopqrstuvwxyz";
            var Random = new Random();

            var stringFirstName = new char[5];
            stringFirstName[0] = FirstLetter[Random.Next(25)];
            for (int i = 1; i < stringFirstName.Length; i++)
            {
                if (i < 2)
                {
                    stringFirstName[i] = SmallLetters[Random.Next(25)];
                }
                else
                {
                    do
                    {
                        stringFirstName[i] = SmallLetters[Random.Next(25)];
                    }
                    while (stringFirstName[i] == stringFirstName[i - 1]);
                }
            }
            var FirstName = new String(stringFirstName);
            return FirstName;
        }
        public string GenerateLastName()
        {
            var FirstLetter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var SmallLetters = "abcdefghijklmnopqrstuvwxyz";
            var Random = new Random();

            var stringLastName = new char[7];
            stringLastName[0] = FirstLetter[Random.Next(25)];
            for (int i = 1; i < stringLastName.Length; i++)
            {
                if (i < 2)
                {
                    stringLastName[i] = SmallLetters[Random.Next(25)];
                }
                else
                {
                    do
                    {
                        stringLastName[i] = SmallLetters[Random.Next(25)];
                    }
                    while (stringLastName[i] == stringLastName[i - 1]);
                }
            }
            var LastName = new String(stringLastName);
            return LastName;
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
        public string GeneratePassword()
        {
            var GeneratePassword = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Random = new Random();

            var stringPassword = new char[20];
            for (int i = 0; i < stringPassword.Length; i++)
            {
                stringPassword[i] = GeneratePassword[Random.Next(GeneratePassword.Length)];
            }

            var password = new String(stringPassword);
            return password;
        }
        public string GenerateEmailAddress()
        {
            return GenerateNumber() + "@gmail.com";
        }
        public string GenerateTitle()
        {
            var Numbers = "12";
            var Random = new Random();

            char Title = Numbers[Random.Next(2)];

            if (Title.ToString() == "1")
            {
                return "uniform-id_gender1";
            }
            else
            {
                return "uniform-id_gender2";
            }
        }
        public string GeneratePhoneNumber()
        {
            var Numbers = "0123456789";
            var Random = new Random();

            var stringPhoneNumber = new char[6];
            for (int i = 0; i < stringPhoneNumber.Length; i++)
            {
                stringPhoneNumber[i] = Numbers[Random.Next(9)];
            }

            var GeneratedPhoneNumber = new String(stringPhoneNumber);
            var PhoneNumber = "+38762" + GeneratedPhoneNumber;
            return PhoneNumber;
        }
        public int GenerateDateOfBirth(int min, int max)
        {
            var Random = new Random();
            int Day = Random.Next(min, max);
            return Day;
        }
        public int GenerateState()
        {
            Random random = new Random();
            int state = random.Next(1, 50);
            return state;
        }
    }
}
