﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    class Brands
    {
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public string Manufactoring_Country { get; set; }
        public Items Item_id { get; set; }

    }
}
