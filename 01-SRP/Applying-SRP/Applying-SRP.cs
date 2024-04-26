namespace _01_SRP.Applying_SRP
{
    /// <summary>
    /// Define la estructura básica de un Producto.
    /// </summary>
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
    }

    /// <summary>
    /// Implementación concreta de la interfaz IProduct.
    /// Representa los datos y la estructura de un producto.
    /// </summary>
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Clase de servicio dedicada a la gestión de productos.
    /// Encargada de las operaciones de negocio como cargar y guardar productos.
    /// </summary>
    public class ProductService
    {
        public void getProduct(int id)
        {
            Console.WriteLine($"Product {id}, name: 'OLED Tv'");
        }

        public void saveProduct(IProduct product)
        {
            Console.WriteLine($"Saving to the database product: {product.Name} with Id: {product.Id}");
        }
    }

    /// <summary>
    /// Servicio para manejar notificaciones por correo electrónico.
    /// Encargado de enviar correos electrónicos a clientes o administradores.
    /// </summary>
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

    /// <summary>
    /// Servicio para la gestión del carrito de compras.
    /// Se encarga de añadir productos al carrito de compras y podría manejar la lógica de pago.
    /// </summary>
    public class CartService
    {
        private List<Product> itemsInCart = new List<Product>();

        public void addToCart(IProduct product)
        {
            Console.WriteLine($"Adding product to cart '{product.Name}'");
        }
    }

    /// <summary>
    /// Clase coordinadora que utiliza varios servicios para manejar la lógica de negocio relacionada con productos.
    /// Facilita operaciones como cargar, guardar productos y enviar notificaciones.
    /// </summary>
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

        public void saveProduct(IProduct product)
        {
            productService.saveProduct(product);
        }
        public void emailNotification()
        {
            emailNotificationsService.notifyClients(new List<string> { "stella@correo.com", "linda@correo.com" }, EmailNotificationService.EmailNotificationType.to_Clients);
        }
    }



    /// <summary>
    /// Este código ha sido refactorizado para adherir al Principio de Responsabilidad Única (SRP),
    /// separando claramente las responsabilidades en distintas clases específicas. 
    /// 
    /// En la versión anterior, la clase ProductBloc manejaba múltiples responsabilidades como la 
    /// carga y guardado de productos, notificación a clientes y gestión del carrito de compras, 
    /// lo que complicaba el mantenimiento y la expansión del código, así como la realización de pruebas.
    /// 
    /// Refactorización realizada:
    /// 1. ProductService: Encargada de las operaciones de negocio relacionadas con productos,
    ///    facilitando la interacción con la base de datos para cargar y guardar productos.
    /// 2. EmailNotificationService: Maneja el envío de notificaciones por correo electrónico,
    ///    permitiendo cambios en la política de notificaciones sin afectar la lógica de negocio de productos.
    /// 3. CartService: Administra todo lo relacionado con el carrito de compras, mejorando
    ///    la modularidad y permitiendo cambios independientes en la lógica del carrito.
    /// 4. ProductBloc: Ahora funciona como un coordinador que utiliza servicios específicos
    ///    para operaciones relacionadas con productos, reduciendo su complejidad y las razones para cambiar.
    ///
    /// Este enfoque mejora significativamente la mantenibilidad y la testabilidad del código,
    /// asegurando que cada clase cumpla con una única responsabilidad y esté abierta a la extensión,
    /// pero cerrada a la modificación, en línea con el SRP.
    /// </summary>
    public class NamespaceDoc // Esta clase se utiliza exclusivamente para la documentación del espacio de nombres.
    {
    }
}
