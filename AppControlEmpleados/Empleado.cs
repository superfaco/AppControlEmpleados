using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlEmpleados
{
    abstract class Empleado : IHumano, IEmpleado
    {
        protected int numeroEmpleado;
        protected string nombre;
        protected DateTime fechaNacimiento;
        public decimal SalarioBase { get; set; }
        public int NumeroEmpleado { get => numeroEmpleado; set => numeroEmpleado = value; }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public Empleado(int numeroEmpleado, string nombre, DateTime fechaNacimiento, decimal salarioBase = 5000)
        {
            this.numeroEmpleado = numeroEmpleado;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.SalarioBase = salarioBase;
        }

        public Empleado(Empleado empleado)
        {
            this.numeroEmpleado = empleado.numeroEmpleado;
            this.nombre = empleado.nombre;
            this.SalarioBase = empleado.SalarioBase;
        }

        public abstract decimal CalcularSalario();

    }
}
