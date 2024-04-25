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
var productBloc = new ProductBloc(productService, emailNotificationService);
productBloc.loadProduct(1);
productBloc.notifyClients();
productBloc.saveProduct(new Product { Id = 3, Name = "LG TV" });

var cartService = new CartService();
cartService.AddToCart(new Product { Id = 3, Name = "LG TV" });