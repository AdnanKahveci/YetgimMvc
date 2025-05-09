namespace Ders4;

public class Product
{
    private string _name;
    private int _stock;
    private double _price;
    private string _categoryName;

    public string Name
    {
        get => _name;
        set => checkNameOrCategoryName(value, _name);
    }

    public int Stock
    {
        get => _stock;
        set => _stock = value;
    }

    public double Price
    {
        get => _price;
        set => _price = value;
    }

    public string CategoryName
    {
        get => _categoryName;
        set => _categoryName = value;
    }

    private void checkNameOrCategoryName(string val, string title)
    {
        if (string.IsNullOrWhiteSpace(val))
            Console.WriteLine($"{title} alanı bos olmaz");
    }

    public Product(string name, int stock, double price, string categoryName)
    {
        Name = name;
        Stock = stock;
        Price = price;
        CategoryName = categoryName;
    }


    public string GetName()
    {
        return _name;
    }

    public int GetStock()
    {
        return _stock;
    }

    public double GetPrice()
    {
        return _price;
    }

    public string GetCategoryName()
    {
        return _categoryName;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            Console.WriteLine("bos");
        Name = name;
    }

    public void SetStock(int stock)
    {
        if (stock < 0)
            Console.WriteLine("negatif");
        Stock = stock;
    }

    public void SetPrice(double price)
    {
        if (price < 0)
            Console.WriteLine("negatif");
        Price = price * 1.20;
    }

    public void SetCategoryName(string categoryName)
    {
        if (string.IsNullOrWhiteSpace(categoryName))
            Console.WriteLine("bos");
        CategoryName = categoryName;
    }
}    