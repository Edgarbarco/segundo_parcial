using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_parcial
{
        public class Task
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public Status Status { get; set; } // Agregado para la versión avanzada
            public string Responsible { get; set; } // Agregado para la versión avanzada

            public Task(string name, string description, DateTime dueDate)
            {
                Name = name;
                Description = description;
                DueDate = dueDate;
                Status = Status.Pending; // Valor predeterminado para la versión avanzada
                Responsible = ""; // Valor predeterminado para la versión avanzada
            }
        }

        public enum Status // Agregado para la versión avanzada
        {
            Pending,
            Completed
        }
    }
}
