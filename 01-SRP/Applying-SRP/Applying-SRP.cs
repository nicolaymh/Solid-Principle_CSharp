

namespace _01_SRP.Applying_SRP
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    //////////////////////////////////////////////////////

    //////////////////////////////////////////////////////
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    //////////////////////////////////////////////////////

    //////////////////////////////////////////////////////
    public class ProductService
    {
        public void getProduct(int id)
        {
            Console.WriteLine($"Product {id}, name: 'OLED Tv'");
        }

        public void saveProduct(Product product)
        {
            Console.WriteLine($"Saving to the database product: {product.Name} with Id: {product.Id}");
        }
    }
    //////////////////////////////////////////////////////    

    //////////////////////////////////////////////////////
    public class EmailNotificationService
    {
        private string emailMaster = "nicolay@correo.com";
        public enum EmailNotificationType { to_Clients = 1, to_Admins = 2 };

        public void notifyClients(List<string> clients, EmailNotificationType template)
        {
            Console.WriteLine($"Sending emails to {template}");
            clients.ForEach(email => Console.WriteLine(email));
        }
    }

    //////////////////////////////////////////////////////
    public class CartService
    {
        private List<Product> itemsInCart = new List<Product>();

        public void addToCart(Product product)
        {
            Console.WriteLine($"Adding product to cart '{product.Name}'");
        }
    }
    //////////////////////////////////////////////////////

    //////////////////////////////////////////////////////
    public class ProductBloc
    {
        private ProductService productService;
        private EmailNotificationService emailNotificationsService;

        public ProductBloc(ProductService productService, EmailNotificationService emailNotificationsService)
        {
            this.productService = productService;
            this.emailNotificationsService = emailNotificationsService;
        }

        public void LoadProduct(int id)
        {
            productService.getProduct(id);
        }

        public void saveProduct(Product product)
        {
            productService.saveProduct(product);
        }
        public void emailNotification()
        {
            emailNotificationsService.notifyClients(new List<string> { "stella@correo.com", "linda@correo.com" }, EmailNotificationService.EmailNotificationType.to_Clients);
        }
    }
}
