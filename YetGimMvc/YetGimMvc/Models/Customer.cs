namespace YetGimMvc.Models;

public sealed class Customer:User
{
    public string CardInfo { get; set; }
    public double Budget { get; set; }
}

public class Employee : User
{
    public string Department { get; set; }
    public double Salary { get; set; }
}

public class User:Entity<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    
    public string Password { get; set; }
}

public class Product:Entity<long>
{
    public string Name { get; set; }
    public string Stock { get; set; }
    public double Price { get; set; }
}

public abstract class Entity<TId>
{
    public TId Id { get; set; }
    public string CreatedAt { get; set; }
    public string UpdatedAt { get; set; }
}

public sealed class Category : Entity<int>
{
    public string Name { get; set; }
}