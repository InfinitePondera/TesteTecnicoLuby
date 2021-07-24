using System;

namespace VendingMachine
{
    public class MenuMaquina
    {
        private Estoque[] _stock = Estoque.CreateStock();
        private Venda[] _sales = Array.Empty<Venda>();

        public Estoque[] Stock
        {
            get => _stock;
            set => _stock = value;
        }

        public Venda[] Sales
        {
            get => _sales;
            set => _sales = value;
        }

        public void ListCommands()
        {
            try
            {
                do
                {
                    Console.WriteLine("Selecione o que deseja fazer:");
                    Console.WriteLine("1 - Comprar bebidas");
                    Console.WriteLine("2 - Consultar Vendas");
                    if (Console.Read() == 1)
                    {
                        ListStock();
                        Console.WriteLine("Digite o ID da bebida desejada: ");
                        DoSale(Console.Read());
                    }
                    else if (Console.Read() == 2)
                    {
                        Console.WriteLine("Vendas realizadas recentemente:");
                        ListSales();
                    }
                    else
                    {
                        Console.WriteLine("Número inválido");
                    }
                } while (true);
            }
            catch(Exception e)
            {
                Console.WriteLine("Um erro inesperado ocorreu.");
            }
            
        }

        public void ListStock()
        {
            for (int i = 0; i < _stock.Length; i++)
            {
                if (_stock[i].Quantity > 0)
                {
                    Console.WriteLine(i + " - " + _stock[i].Product.Name + " Preço: R$" + _stock[i].Product.Price);
                }
            }
        }

        public void ListSales()
        {
            if (_sales.Length > 0)
            {
                Console.WriteLine("Não há vendas recentes!");
            }

            foreach (var t in _sales)
            {
                Console.WriteLine(t.Id + t.ValorVenda.ToString() + t.Date);
            }
        }

        public void DoSale(int option)
        {
            Console.WriteLine("O preço total é de: R$" + _stock[option].Product.Price);
            Console.WriteLine("Qual o valor que irá pagar?");
            var aux = Console.Read();
            if (_stock[option].Product.Price == aux)
            {
                Console.WriteLine("Obrigado pela compra!");
                _stock[option].Quantity--;
            }
            else
            {
                Console.WriteLine("O seu troco será de: R$" + (aux - _stock[option].Product.Price));
                Console.WriteLine("Obrigado pela compra!");
                _stock[option].Quantity--;
            }
        }
        
    }
}