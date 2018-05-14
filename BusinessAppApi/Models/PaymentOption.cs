using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessAppApi.Enums;

namespace BusinessApp.Models
{
    public class PaymentOption : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        public PaymentType PayType { get; set; }

    }
}
