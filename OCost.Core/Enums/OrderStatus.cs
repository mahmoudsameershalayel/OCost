using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Core.Enums
{
    public enum OrderStatus
    {
        Confirmed = 0,
        InProgress = 1,
        Shipped = 2,
        Delivered = 3,
        Cancelled = 4,
        OnHold = 5,
        Completed = 6,
        Processing = 7,
        Pending = 8,
        /*
        Pending: The order has been created but has not yet been processed or confirmed.
        Processing: The order is being processed by the system or by staff members.
        Confirmed: The order has been confirmed and is awaiting fulfillment.
        In Progress: The order is currently being fulfilled or assembled.
        Shipped: The order has been shipped or dispatched to the customer.
        Delivered: The order has been delivered to the customer.
        Cancelled: The order has been cancelled by either the customer or the system administrator.
        On Hold: The order is temporarily on hold for some reason (e.g., awaiting further instructions, out of stock items).
        Completed: The order has been successfully processed, fulfilled, and delivered to the customer.
        */
    }
}
