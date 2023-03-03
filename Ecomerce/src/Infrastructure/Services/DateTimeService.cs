using Ecomerce.Application.Common.Interfaces;

namespace Ecomerce.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
