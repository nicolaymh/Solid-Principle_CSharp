

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

// Violacion principio SRP de responsabilidad unica:
// La clase ProductBloc actualmente maneja varias responsabilidades que no están estrechamente relacionadas,
// lo que viola el Principio de Responsabilidad Única (SRP). Esta violación hace que la clase sea más difícil de
// mantener y de testear, ya que cambios en una responsabilidad (como la lógica de notificación) podrían
// requerir cambios en una clase que también maneja otras responsabilidades completamente distintas (como la
// gestión de productos o eventos del carrito). Idealmente, cada responsabilidad debería estar encapsulada
// en su propia clase para mejorar la cohesión y facilitar la extensión y el mantenimiento del código.
