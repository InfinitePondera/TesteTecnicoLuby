using System;

namespace VendingMachine
{
    public class Venda
    {
        private int _id;
        private double _valorVenda;
        private DateTime _date;

        public Venda(int id, double valorVenda, DateTime date)
        {
            _id = id;
            _valorVenda = valorVenda;
            _date = date;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public double ValorVenda
        {
            get => _valorVenda;
            set => _valorVenda = value;
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        
    }
}