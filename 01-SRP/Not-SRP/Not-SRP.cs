

namespace _01_SRP.Not_SRP
{

    // Defining the Product interface.
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
    }

    // Class that implements the Product interface.
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    // Class to control the view displayed to the user.
    public class ProductBloc
    {
        public void LoadProduct(int id)
        {
            Console.WriteLine($"Product {id}, name: 'OLED Tv'");
        }

        public void SaveProduct(IProduct product)
        {
            Console.WriteLine($"Saving to the database product: {product.Name} with Id: {product.Id}");
        }

        public void NotifyClients()
        {
            Console.WriteLine($"Sending emails to the clients");
        }

        public void OnAddToCart(int productId)
        {
            Console.WriteLine($"Adding to cart {productId}");
        }

    }
}

