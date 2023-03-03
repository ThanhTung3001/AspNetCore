namespace Ecomerce.Domain.Entities;

public class Category:BaseEntityPrimary
{
    public string Name { set; get; }
    
    public string Image { set; get; }
    
    public IEnumerable<Product> Products { set; get; }

}