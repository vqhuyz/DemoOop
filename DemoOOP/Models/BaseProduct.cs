using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoOOP.Models
{
    public abstract class BaseProduct
    {
        public abstract int Id { get; set; }
        public abstract DateTime CreateAt { get; set; }
    }
}