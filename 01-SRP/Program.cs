using _01_SRP.Not_SRP;


// Instanciando Not-SRP

var product = new ProductBloc();
product.LoadProduct(9);
product.OnAddToCart(4);
product.NotifyClients();
var myProduct = new Product { Id = 1, Name = "Smartphone LG" };
product.SaveProduct(myProduct);
