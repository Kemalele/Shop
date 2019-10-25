/*
 * 1. Регистрация и вход (смс-код / email код) - сделать до 11 октября
 * 2. История покупок
 * 3. Категории и товары (картинка в файловой системе)
 * 4. Покупка (корзина), оплата и доставка (PayPal/Qiwi/etc)
 * 5. Комментарии и рейтинги
 * 6. Поиск (пагинация)
 * 
 * Кто сделает 3 версии (Подключённый, автономный и EF) получит автомат на экзамене.
 */

using Microsoft.Extensions.Configuration;
using Shop.DataAccess;
using Shop.Domain;
using System.IO;
using System.Linq;
using System;
using Shop.Services;
using static System.Console;
using static System.Convert;

namespace Shop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int chosenMenu;
                var registrationService = new RegistrationService();
                Clear();
                WriteLine("1.Войти");
                WriteLine("2.Регистрация");
                chosenMenu = ToInt32(ReadLine());

                switch (chosenMenu)
                {
                    case 1:
                        
                        break;

                    case 2:

                        registrationService.Register();
                        break;

                }

            }
        }
    }
}
