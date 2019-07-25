using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RushTodo.Web.Models
{
    public class GetModel
    {
        public Guid? Id { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }
    }
}
