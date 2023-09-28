using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string[] Colors { get; set; }
    public int Brand { get; set; }
    public Product(int id, string name, double price, string[] colors, int brand)
    {
        ID = id;
        Name = name;
        Price = price;
        Colors = colors;
        Brand = brand;
    }
    override public string ToString() => $"{ID,3}{Name,12}{Price,5}{Brand,2}{string.Join(", ", Colors)}";
}

class Brand
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var brands = new List<Brand>()
        {
            new Brand() { ID = 1, Name = "Cong ty AAA"},
            new Brand() { ID = 2, Name = "Cong ty BBB"},
            new Brand() { ID = 3, Name = "Cong ty CCC"},
        };

        var products = new List<Product>()
        {
            new Product(1, "Bàn trà", 400, new string[] {"xám", "xanh" }, 2),
            new Product(2, "Tranh treo", 400, new string[] {"vàng", "xanh"}, 1),
            new Product(3, "Đèn trùm", 500, new string[] {"trắng"}, 4),
            new Product(4, "Bàn học", 200, new string[] {"trắng", "xanh"}, 1),
            new Product(5, "Túi da", 300, new string[] {"đỏ", "đen", "vàng"}, 2),
            new Product(6, "Giường ngủ", 500, new string[] {"trắng"}, 2),
            new Product(7, "Tủ áo", 600, new string[] {"trắng"}, 4),
        };

        var ketqua = from product in products
                     join brand in brands on product.Brand equals brand.ID into t
                     from brand in t.DefaultIfEmpty()
                     select new
                     {
                         name = product.Name,
                         brand = (brand == null) ? "NO-BRAND" : brand.Name,
                         price = product.Price
                     };

        foreach (var item in ketqua)
        {
            Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
        }

    }
}
