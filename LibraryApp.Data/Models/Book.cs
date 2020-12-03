﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
    }
}
