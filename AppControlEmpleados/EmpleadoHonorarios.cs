using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlEmpleados
{
    class EmpleadoHonorarios : Empleado
    {
        private decimal comisionPorVenta;
        public decimal ComisionPorVenta { get { return comisionPorVenta; } set { if (value > 0) comisionPorVenta = value; else throw new Exception("La comisión por venta debe ser igual o mayor a 1."); } }
        public int NumeroDeVentas { get; private set; }

        public EmpleadoHonorarios(EmpleadoHonorarios empleado) : base(empleado)
        {
            this.ComisionPorVenta = empleado.ComisionPorVenta;
            this.NumeroDeVentas = empleado.NumeroDeVentas;
        }

        public EmpleadoHonorarios(int numeroEmpleado, string nombre, DateTime fechaNacimiento, decimal salarioBase = 5000, decimal comisionPorVentas = 100) : base(numeroEmpleado, nombre, fechaNacimiento, salarioBase)
        {
            this.ComisionPorVenta = comisionPorVentas;
            NumeroDeVentas = 0;
        }

        public void CargarVentas(int numeroDeVentas)
        {
            if (numeroDeVentas > 0)
                this.NumeroDeVentas += numeroDeVentas;
            else
                throw new Exception("Tiene que cargar al menos 1 venta");
        }
        public override decimal CalcularSalario()
        {
            return SalarioBase + ComisionPorVenta * NumeroDeVentas;
        }
    }
}
