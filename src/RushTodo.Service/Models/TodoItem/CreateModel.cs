﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Service.Models.TodoItem
{
    public class CreateModel
    {
        public string Description { get; set; }

        public DateTime DueDate
        {
            get; set;
        }
    }
}
