using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Shop.Services
{
    public class RegistrationService
    {
        public void Register()
        {
            string email;
            string password;
            string phoneNumber;
            string address;

            WriteLine("Введите e-mail: ");
            email = ReadLine() as string;

            WriteLine("Введите пароль");
            password = ReadLine() as string;

            Authenicate(email);
        }

        private bool Authenicate(string emailTo)
        {

            var emailFrom = "kemalele17@gmail.com";
            var emailPassword = "kk240673";
            var messageSubject = "Аутентификация";

            string generatedCode;
            string enteredCode;

            var codeGenerator = new CodeGenerator();
            var messageSender = new MessageSender();

            generatedCode = codeGenerator.Generate();
            messageSender.Send(generatedCode, messageSubject, emailFrom, emailTo, emailPassword);

            WriteLine("Введите полученный код:");
            enteredCode = ReadLine() as string;

            if (string.Compare(generatedCode, enteredCode).Equals(1))
                return true;

            else return false;
        }
    }
}
