namespace Ecomerce.Domain.Entities;

public class Product : BaseEntityPrimary
{
    public string Name { set; get; }
    
    public float Price { set; get; }
    
    public Category Category { set; get; }
    
    public FileType FileTypes { set; get; }
    
}