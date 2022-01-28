using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OopsSample1
{
    internal class Encapsulation
    {
        public void Login(string userName,string password)
        {
            if (Validate(userName, password))
            {
                DbConnection();
                if(Authentication(userName, password))
                {
                    Console.WriteLine("You have signedIn");
                }
                else
                {
                    Console.WriteLine("failed to authentication");
                }
            }
            else
            {
                Console.WriteLine("Invalid format ");
            }
        }
        private bool Validate(string userName,string Password)
        {
            //username must have morethan 3
            //password must have morethan 8 letters and one alphanumerecal letter
            //validate the username and password
            return true;
        }
        private void DbConnection()
        {
            //establish Database connection
        } 
        private bool Authentication(string userName,string password)
        {
            if(userName == "subin" && password == "subin@123")
            {
                return true;
            }
            return false;
        }

        /*public static bool isValidMobileNumber(string userName)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            // Class Regex Represents an
            // immutable regular expression.
            //   Format                Pattern
            // xxxxxxxxxx           ^[0 - 9]{ 10}$
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate
            // a string or to ensure that a string
            // conforms to a particular pattern.
            if (re.IsMatch(userName))
                return (true);
            else
                return (false);
        }*/
    }
}
