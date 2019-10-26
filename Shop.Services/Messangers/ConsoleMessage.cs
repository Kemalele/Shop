using System;
namespace Shop.Services.Messangers
{
    public class ConsoleMessage : IMessage
    {
       public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
