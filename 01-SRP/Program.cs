//using _01_SRP.Not_SRP;
using _01_SRP.Applying_SRP;



// Instanciando Not-SRP
//var product = new ProductBloc();
//product.LoadProduct(1);
//product.NotifyClients();
//product.OnAddToCart(1);
//IProduct myProduct = new Product { Id = 2, Name = "LG TV" };
//Console.WriteLine(myProduct.Name);
//product.SaveProduct(myProduct);

////////////////////////////////////////////////////////////////////////

// Instanciando Applying-SRP
var productService = new ProductService();
var emailNotificationService = new EmailNotificationService();
var myProduct = new ProductBloc(productService, emailNotificationService);
myProduct.LoadProduct(2);
myProduct.saveProduct(new Product { Id = 1, Name = "LG TV" });
myProduct.emailNotification();

var cartService = new CartService();
cartService.addToCart(new Product { Id = 5, Name = "Challenger Monitor" });