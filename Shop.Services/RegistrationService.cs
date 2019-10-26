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
        public void Register(IMessage messanger)
        {
            string email;
            string password;
            string phoneNumber;
            string address;

            messanger.Send("Введите e-mail: ");
            email = ReadLine() as string;

            messanger.Send("Введите пароль: ");
            password = ReadLine() as string;

            messanger.Send("Введите номер телефона: ");
            phoneNumber = ReadLine() as string;

            messanger.Send("Введите домашний адресс: ");
            address = ReadLine() as string;

            if (Authenicate(email, messanger))
            {
                var User = EntityBuilder.CreateUser(phoneNumber, email, address, password);
                var userRepo = EntityBuilder.CreateUserRepo();
                userRepo.Add(User);
            }
        }

        private bool Authenicate(string emailTo , IMessage messanger)
        {

            var emailFrom = "kemalele17@gmail.com";
            var emailPassword = "kk240673";
            var messageSubject = "Аутентификация";

            string generatedCode;
            string enteredCode;

            var codeGenerator = new CodeGenerator();
            var mailMessage = new MailMessage();

            generatedCode = codeGenerator.Generate();
            mailMessage.Send(generatedCode, messageSubject, emailFrom, emailTo, emailPassword);

            messanger.Send("Введите полученный код:");
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
