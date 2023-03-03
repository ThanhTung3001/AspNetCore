namespace Ecomerce.Domain.Entities;

public class Attachment:BaseEntity
{
    public string Name { get;set; }
    
    public FileType FileType { set; get; }
    
}