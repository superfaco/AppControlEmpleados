using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlEmpleados
{
    class EmpleadoFijo : Empleado
    {
        private decimal pagoPorHoraExtra;
        public decimal PagoPorHoraExtra { get { return pagoPorHoraExtra; } set { if (value > 300) pagoPorHoraExtra = value; else throw new Exception("El pago por hora extra no puede ser menor a 300."); } }
        public int HorasExtras { get; private set; }

        public EmpleadoFijo(EmpleadoFijo empleado) : base(empleado)
        {
            this.HorasExtras = empleado.HorasExtras;
            this.PagoPorHoraExtra = empleado.PagoPorHoraExtra;
        }

        public EmpleadoFijo(int numeroEmpleado, string nombre, DateTime fechaNacimiento, decimal salarioBase = 5000, decimal pagoPorHoraExtra = 350) : base(numeroEmpleado, nombre, fechaNacimiento, salarioBase)
        {
            this.PagoPorHoraExtra = pagoPorHoraExtra;
            this.HorasExtras = 0;
        }

        public void CargarHorasExtras(int numeroDeHoras)
        {
            if (numeroDeHoras > 0)
                HorasExtras += numeroDeHoras;
            else
                throw new Exception("No puede cargar horas extras negativas.");
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase + HorasExtras * PagoPorHoraExtra;
        }
    }
}
