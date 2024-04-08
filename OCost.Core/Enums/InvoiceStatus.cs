using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Core.Enums
{
    public enum InvoiceStatus
    {
        Draft=0,
        Pending =1,
        PartiallyPaid =3,
        Paid=4,
        Overdue =5,
        Cancelled =6,
        Processing=7,
        Refunded=8,
        Disputed=9,
        /*
         Draft: The invoice has been created but not yet finalized or sent to the customer.
         Pending: The invoice has been sent to the customer and is awaiting action (e.g., payment, approval).
         Partially Paid: A partial payment has been made for the invoice, but the full amount is still outstanding.
         Paid: The invoice has been paid in full by the customer.
         Overdue: The payment due date has passed, and the invoice remains unpaid.
         Cancelled: The invoice has been cancelled, either by the sender or the recipient, and is no longer valid.
         Void: The invoice has been declared void and is no longer applicable.
         Processing: The payment for the invoice is currently being processed.
         Refunded: The payment for the invoice has been refunded to the customer.
         Disputed: The invoice amount or details are being disputed, and resolution is pending.
        */

    }
}
