namespace Ecomerce.Domain.Common;

public class BaseEntityPrimary
{
    public  Guid Id { set; get; }
    
    public DateTime CreateDate { set; get; }
    
    public DateTime ModifyDate { set; get; }
    
    
}