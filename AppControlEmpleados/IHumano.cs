using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlEmpleados
{
    interface IHumano
    {
        string Nombre { get; set; }
        DateTime FechaNacimiento { get; set; }
    }
}
