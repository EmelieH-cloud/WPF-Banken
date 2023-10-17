using System;

namespace WPF_Banken
{
    public class Validator
    {

        public Validator() { }

        public bool ValidateInputLength(string username)

        {
            if (string.IsNullOrEmpty(username) || username.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public bool CountNumbers(string input)
        {
            char[] chars = input.ToCharArray();
            int numberOfDigits = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                bool ContainsDigit = Char.IsDigit(chars[i]);
                if (ContainsDigit)
                {
                    numberOfDigits++;
                }
            }
            //---------------------------------------------- End of loop 
            if (numberOfDigits < 3)
            {
                return false;
            }
            else
            {
                return true;
            }


        }


    }
}
