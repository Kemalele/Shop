using System;
namespace Shop.Services
{
    public interface IMessage
    {
        public void Send(string message) { }
    }
}
