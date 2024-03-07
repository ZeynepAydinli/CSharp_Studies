using LinqProject;

List<Category> categories = new List<Category>
{
    new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
    new Category{CategoryId = 2, CategoryName = "Telefon"},
};

List<Product> products = new List<Product>
{
    new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 5},
    new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 8000, UnitsInStock = 3},
    new Product{ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 10000, UnitsInStock = 2},
    new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitsInStock = 15},
    new Product{ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitsInStock = 0},
};

Console.WriteLine("---------- Algoritmik ----------");

foreach (var product in products)
{
    if(product.UnitPrice > 5000 && product.UnitsInStock > 3)
    {
        Console.WriteLine(product.ProductName);
    }
}

Console.WriteLine("---------- Linq ----------");

var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3); // p, for döngüsündeki product anlamına gelir. Genelde ilk harfi yazılır. 

var result2 = products.Where(p => p.ProductName.Contains("Laptop")).OrderBy(p => p.UnitPrice); // order by asc

var result3 = products.Where(p => p.ProductName.Contains("Laptop")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);

// thenby: Bir dizideki öğelerin sonraki sıralamasını artan düzende gerçekleştirir.

// IEnumerable dan result'un array tabanlı olduğu anlaşılır.

foreach (var product in result3)
{
    Console.WriteLine(product.ProductName);
}


Console.WriteLine("---------- Inner Join ----------");

var result4 = from p in products
              join c in categories
              on p.CategoryId equals c.CategoryId
              where p.UnitPrice > 5000
              orderby p.UnitPrice descending  
              select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

foreach (var productDto in result4)
{
    Console.WriteLine(productDto.ProductName + " " + productDto.CategoryName);
}


// Method
Console.WriteLine("---------- Method ----------");
GetProducts(products);

static List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredProducts = new List<Product>();

    foreach (var product in products)
    {
        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
        {
            filteredProducts.Add(product);
        }
    }

    return filteredProducts;
}

static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();  // ToList yazılmazsa hata verir. 

    // where komutu şartı uyanları arka planda yeni bir list'e ekleme yapar. 
    // Böylece yukarıda ki kod da olduğu gibi yeni bir list yazmaya gerek kalmadı.

}

