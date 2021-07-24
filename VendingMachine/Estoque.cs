namespace VendingMachine
{
    public class Estoque
    {
        private Produto _product;
        private int _quantity;

        public Estoque(Produto product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public Produto Product
        {
            get => _product;
            set => _product = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public static Estoque[] CreateStock()
        {
            Produto pepsi = new(0,"Pepsi", 2.16);
            Produto soda = new(1, "Soda", 2.99);
            Produto coca = new(2, "Coca-Cola", 2.25);
            Produto schweppes = new(3, "Schweppes Citrus", 2.39);

            Estoque pepsiStock = new(pepsi, 8);
            Estoque sodaStock = new(soda, 5);
            Estoque cocaStock = new(coca, 10);
            Estoque schweppesStock = new(schweppes, 4);

            Estoque[] stock = {pepsiStock, sodaStock, cocaStock, schweppesStock};
            
            return stock;
        }
    }
}