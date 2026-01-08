using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Shared.Enum
{
   public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded,
        PartiallyPaid
    }
}
