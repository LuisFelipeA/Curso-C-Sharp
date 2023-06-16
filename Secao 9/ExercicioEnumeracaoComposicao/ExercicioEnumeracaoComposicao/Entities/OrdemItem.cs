using System.Globalization;
using System.Text;

namespace ExercicioEnumeracaoComposicao.Entities
{
    class OrdemItem
    {
        public int Quantity{ get; set; }
        public Double Price { get; set; }
        public Product Product { get; set; }
        public OrdemItem() { }

        public OrdemItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Quantity: ");
            sb.Append(Quantity.ToString());
            sb.Append(", Subtotal: $");
            sb.Append(subTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
