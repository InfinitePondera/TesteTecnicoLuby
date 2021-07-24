namespace VendingMachine
{
    public class Produto
    {
        private int _id;
        private string _name;
        private double _price;

        public Produto()
        {
            this._name = null;
            this._price = 0;
        }
        public Produto(int id, string name, double price)
        {
            this._name = name;
            this._price = price;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Price
        {
            get => _price;
            set
            {
                if(value > 0) _price = value;
            } 
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
    }
}