using static _01_SRP.Applying_SRP.EmailNotificationService;

namespace _01_SRP.Applying_SRP
{

    /////////////////////////////////////////    
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    //////////////////////////////////////////

    //////////////////////////////////////////
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    //////////////////////////////////////////

    //////////////////////////////////////////
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
    //////////////////////////////////////////

    //////////////////////////////////////////
    public class CartService
    {
        private List<Product> itemsInCart = new List<Product>();

        public void AddToCart(Product product)
        {
            Console.WriteLine($"Adding to cart {product.Id}, {product.Name}");
        }
    }
    //////////////////////////////////////////

    //////////////////////////////////////////
    public class EmailNotificationService
    {

        private string emailMaster = "nicolay@correo.com";
        public enum EmailTemplate { toAdmins = 1, toClients = 2 };

        public void sendEmail(List<string> emails, EmailTemplate template)
        {
            if (template == EmailTemplate.toAdmins) Console.WriteLine($"Sending email to admins {EmailTemplate.toAdmins}");
            if (template == EmailTemplate.toClients) Console.WriteLine($"Sending email to clients {EmailTemplate.toClients}");
        }
    }
    //////////////////////////////////////////

    //////////////////////////////////////////
    public class ProductBloc
    {
        private ProductService productService;
        private EmailNotificationService emailNotification;

        public ProductBloc(ProductService productService, EmailNotificationService emailNotification)
        {
            this.productService = productService;
            this.emailNotification = emailNotification;
        }

        public void loadProduct(int id)
        {
            productService.getProduct(id);
        }

        public void saveProduct(Product product)
        {
            productService.saveProduct(product);
        }

        public void notifyClients()
        {
            emailNotification.sendEmail(new List<string> { "stella@correo.com", "linda@correo.com" }, EmailTemplate.toAdmins);
        }
    }
    //////////////////////////////////////////
}
