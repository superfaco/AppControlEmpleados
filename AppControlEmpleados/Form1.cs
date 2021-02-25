using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlEmpleados
{
    public partial class Form1 : Form
    {
        private int numeroDeEmpleado;
        private List<Empleado> empleados;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioTipoEmpleado_CheckedChange(object sender, EventArgs e)
        {
            if (sender == radioEmpleadoFijo)
            {
                groupTipoEmpleado.Text = "Empleado Fijo";
                lblDinero.Text = "Pago por Hora Extra:";
            }
            else if(sender == radioEmpleadoHonorarios)
            {
                groupTipoEmpleado.Text = "Empleado por Honorarios";
                lblDinero.Text = "Comisión por Venta:";
            }
            Point p = new Point(lblDinero.Location.X + lblDinero.ClientSize.Width + 7, nudDineroExtra.Location.Y);
            nudDineroExtra.Location = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioEmpleadoFijo.Checked = true;
            numeroDeEmpleado = 1;
            nudID.Value = numeroDeEmpleado;
            empleados = new List<Empleado>();
        }

        private void RefreshGrid()
        {
            dgvEmpleados.Rows.Clear();
            foreach (Empleado emp in empleados)
            {
                dgvEmpleados.Rows.Add(emp.NumeroEmpleado, emp.Nombre, emp.FechaNacimiento, (emp is EmpleadoFijo ? "Empleado Fijo" : "Empleado por Honorarios"));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            formPanel.Enabled = false;

            try
            {
                Empleado empleado = empleados.Find(emp => emp.NumeroEmpleado == nudID.Value);

                #region INSERTAR EMPLEADO
                if (empleado == null)
                {
                    if (radioEmpleadoFijo.Checked)
                    {
                        empleado = new EmpleadoFijo((int)nudID.Value, tbxNombre.Text, dtpFecNac.Value, nudDineroBase.Value, nudDineroExtra.Value);
                    }
                    else if (radioEmpleadoHonorarios.Checked)
                    {
                        empleado = new EmpleadoHonorarios((int)nudID.Value, tbxNombre.Text, dtpFecNac.Value, nudDineroBase.Value, nudDineroExtra.Value);
                    }

                    empleados.Add(empleado);
                    numeroDeEmpleado++;
                }
                #endregion
                #region ACTUALIZAR EMPLEADO
                else
                {
                    if((empleado is EmpleadoFijo && radioEmpleadoHonorarios.Checked) || (empleado is EmpleadoHonorarios && radioEmpleadoFijo.Checked))
                    {
                        Empleado empleadoAux = null;
                        if (radioEmpleadoFijo.Checked)
                        {
                            empleadoAux = new EmpleadoFijo(empleado.NumeroEmpleado, tbxNombre.Text, dtpFecNac.Value, nudDineroBase.Value, nudDineroExtra.Value);
                        }
                        else if (radioEmpleadoHonorarios.Checked)
                        {
                            empleadoAux = new EmpleadoHonorarios(empleado.NumeroEmpleado, tbxNombre.Text, dtpFecNac.Value, nudDineroBase.Value, nudDineroExtra.Value);
                        }
                        empleados.Insert(empleados.IndexOf(empleado), empleadoAux);
                        empleados.Remove(empleado);
                    }
                    else
                    {
                        empleado.Nombre = tbxNombre.Text;
                        empleado.FechaNacimiento = dtpFecNac.Value;
                        if (empleado is EmpleadoFijo)
                        {
                            (empleado as EmpleadoFijo).PagoPorHoraExtra = nudDineroExtra.Value;
                        }
                        else if (empleado is EmpleadoHonorarios)
                        {
                            (empleado as EmpleadoHonorarios).ComisionPorVenta = nudDineroExtra.Value;
                        }
                    }
                }
                #endregion

                RefreshGrid();
                CleanForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            formPanel.Enabled = true;
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvEmpleados.Rows[e.RowIndex].Cells["IDColumn"].Value;
            Empleado empleado = empleados.Find(emp => emp.NumeroEmpleado == id);

            nudID.Value = empleado.NumeroEmpleado;
            tbxNombre.Text = empleado.Nombre;
            dtpFecNac.Value = empleado.FechaNacimiento;
            nudDineroBase.Value = empleado.SalarioBase;
            nudDineroExtra.Value = (empleado is EmpleadoFijo ? (empleado as EmpleadoFijo).PagoPorHoraExtra : (empleado as EmpleadoHonorarios).ComisionPorVenta);
            if(empleado is EmpleadoFijo)
            {
                radioEmpleadoFijo.Checked = true;
            }
            else if(empleado is EmpleadoHonorarios)
            {
                radioEmpleadoHonorarios.Checked = true;
            }
            btnBorrar.Enabled = true;
        }

        private void CleanForm()
        {
            nudID.Value = numeroDeEmpleado;
            tbxNombre.Clear();
            dtpFecNac.Value = DateTime.Now;
            radioEmpleadoFijo.Checked = true;
            nudDineroBase.Value = nudDineroBase.Minimum;
            nudDineroExtra.Value = nudDineroExtra.Minimum;
            btnBorrar.Enabled = false;
            tbxNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes.Equals(MessageBox.Show("¿Está seguro que desea borrar al empleado seleccionado?", "Advertencia", MessageBoxButtons.YesNo)))
            {
                Empleado empleado = empleados.Find(emp => emp.NumeroEmpleado == nudID.Value);
                if (empleado != null)
                {
                    empleados.Remove(empleado);
                    numeroDeEmpleado--;
                    CleanForm();
                    RefreshGrid();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Empleado!!!!");
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numeroDeEmpleado = 1;
            empleados.Clear();
            CleanForm();
            RefreshGrid();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                empleados = EmpleadoFileBin.Abrir(openFileDialog.FileName);
                if(empleados != null)
                {
                    int maxId = 1;
                    for(int i = 0; i < empleados.Count; i++)
                    {
                        if(empleados[i].NumeroEmpleado > maxId)
                        {
                            maxId = empleados[i].NumeroEmpleado;
                        }
                    }
                    this.numeroDeEmpleado = maxId + 1;
                    CleanForm();
                    RefreshGrid();
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                EmpleadoFileBin.Guardar(saveFileDialog.FileName, empleados);
                MessageBox.Show("Empleados guardados con éxito.");
            }
        }
    }
}
