﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Storage
{
    class Stored
    {
        public int Id { get; set; }  // primary key

        public string StorageName { get; set; }
        public Storages Storage { get; set; }

        public string ItemName { get; set; }
        public Items Item { get; set; }

        public int TotalUnits { get; set; }
    }
}
