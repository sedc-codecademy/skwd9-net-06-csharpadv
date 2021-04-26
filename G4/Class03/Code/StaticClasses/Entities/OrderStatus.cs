using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses.Entities
{
    public enum OrderStatus
    {
        Processing,
        DeliveryInProgress,
        Delivered,
        CouldNotDeliver,
        Cancelled
    }
}
