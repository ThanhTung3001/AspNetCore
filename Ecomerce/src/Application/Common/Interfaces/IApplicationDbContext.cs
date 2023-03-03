using Ecomerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    
    DbSet<Product> Products { get; }
    
    DbSet<Category>Categories { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
