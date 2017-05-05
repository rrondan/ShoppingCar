using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Portal
{
    public class Item
    {
        [Key]
        public Int32 id { get; set; }
        public String nombre { get; set; }
        public Int32 stock { get; set; }
        public String descripcion { get; set; }
    }
}