﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore.Data.Models
{
    public class GameTag
    {
        public int GameID { get; set; }
        public Game Game { get; set; }
        public int TagID { get; set; }
        public Tag Tag { get; set; }
    }
}
