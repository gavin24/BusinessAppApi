﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessApp.Models
{
   public class Account:Model
   {
      
       public long Id { get; set; }
       public long ClientId { get; set; }
       public string AccountName { get; set; }



   }
}
