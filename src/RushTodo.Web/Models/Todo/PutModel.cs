﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RushTodo.Web.Models.Todo
{
    public class PutModel
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
