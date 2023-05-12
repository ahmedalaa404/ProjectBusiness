﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.DAL.Extend;

namespace Work.DAL.Entity
{
    public class Rate
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Sender { get; set; }


    }
}
