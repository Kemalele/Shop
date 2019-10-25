using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Shop.Domain;
using Shop.DataAccess;

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

            WriteLine("Введите пароль: ");
            password = ReadLine() as string;

            WriteLine("Введите номер телефона: ");
            phoneNumber = ReadLine() as string;

            WriteLine("Введите домашний адресс: ");
            address = ReadLine() as string;

            if (Authenicate(email))
            {
                var User = EntityBuilder.CreateUser(phoneNumber, email, address, password);
                var dbController = EntityBuilder.CreateDbController();
                dbController.Insert(User);
            }
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

            if (generatedCode.Equals(enteredCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
