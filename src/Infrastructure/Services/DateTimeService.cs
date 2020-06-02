using AzureTest.Application.Common.Interfaces;
using System;

namespace AzureTest.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
