using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlEmpleados
{
    static class EmpleadoFileBin
    {
        private enum TipoDeEmpleado
        {
            FIJO = 0,
            POR_HONORARIOS = 1
        }

        public static bool Guardar(string fileName, List<Empleado> empleados)
        {
            FileStream fs = null;
            BinaryWriter bw = null;
            bool ok = false;
            try
            {
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(fs);
                //id-nombre-fecnac-tipoemp-salariobase-salarioextra
                foreach(Empleado emp in empleados)
                {
                    bw.Write(Encriptador.Encriptar(emp.NumeroEmpleado));
                    bw.Write(Encriptador.Encriptar(emp.Nombre));
                    bw.Write(Encriptador.Encriptar(Encriptador.Encriptar(emp.FechaNacimiento).ToString()));
                    bw.Write(Encriptador.Encriptar(emp is EmpleadoFijo ? (int)TipoDeEmpleado.FIJO : (int)TipoDeEmpleado.POR_HONORARIOS));
                    bw.Write(Encriptador.Encriptar(emp.SalarioBase));
                    bw.Write(Encriptador.Encriptar(emp is EmpleadoFijo ? (emp as EmpleadoFijo).PagoPorHoraExtra : (emp as EmpleadoHonorarios).ComisionPorVenta));
                }
                bw.Flush();
                ok = true;
            }
            catch (Exception e)
            {
                ok = false;
                throw e;
            }
            finally
            {
                if (bw != null)
                    bw.Close();
                if (fs != null)
                    fs.Close();
            }
            return ok;
        }

        public static List<Empleado> Abrir(string fileName)
        {
            List<Empleado> empleados = new List<Empleado>();
            using (BinaryReader br = new BinaryReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
            {
                while(br.BaseStream.Position < br.BaseStream.Length)
                {
                    int id = Encriptador.Desencriptar(br.ReadInt32());
                    string nombre = Encriptador.Desencriptar(br.ReadString());
                    DateTime fecnac = Encriptador.Desencriptar(DateTime.Parse(Encriptador.Desencriptar(br.ReadString())));
                    TipoDeEmpleado tipoDeEmpleado = (TipoDeEmpleado)Encriptador.Desencriptar(br.ReadInt32());

                    Empleado emp = null;

                    switch (tipoDeEmpleado)
                    {
                        case TipoDeEmpleado.FIJO:
                            emp = new EmpleadoFijo(id, nombre, fecnac, Encriptador.Desencriptar(br.ReadDecimal()), Encriptador.Desencriptar(br.ReadDecimal()));
                            break;
                        case TipoDeEmpleado.POR_HONORARIOS:
                            emp = new EmpleadoHonorarios(id, nombre, fecnac, Encriptador.Desencriptar(br.ReadDecimal()), Encriptador.Desencriptar(br.ReadDecimal()));
                            break;
                        default:
                            break;
                    }

                    if(emp != null)
                    {
                        empleados.Add(emp);
                    }
                }
            }
            return empleados;
        }
    }
}
