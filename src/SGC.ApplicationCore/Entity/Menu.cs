﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.ApplicationCore.Entity
{
    public class Menu
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int? MenuId{ get; set; }
        public ICollection<Menu> SubMenu { get; set; }
    }
}
