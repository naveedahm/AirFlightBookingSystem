using AirlineBoookingSystem.Payments.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineBoookingSystem.Payments.Core.Repositories
{
    public interface IPaymentRepository
    {
        Task ProcessPaymentsAsync(Payment payments);

        Task RefundPaymentAsync(Guid id);

    }
}
