using c_aiguise.Application.Common.Interfaces;

namespace c_aiguise.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
