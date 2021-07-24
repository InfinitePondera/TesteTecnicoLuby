using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuMaquina menu = new MenuMaquina();
            Console.WriteLine("Bem-vindo a máquina de vendas");
            menu.ListCommands();
        }
    }
}