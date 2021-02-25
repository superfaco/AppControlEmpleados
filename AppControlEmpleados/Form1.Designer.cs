
namespace AppControlEmpleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.formPanel = new System.Windows.Forms.GroupBox();
            this.groupTipoEmpleado = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudDineroExtra = new System.Windows.Forms.NumericUpDown();
            this.lblDinero = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioEmpleadoHonorarios = new System.Windows.Forms.RadioButton();
            this.radioEmpleadoFijo = new System.Windows.Forms.RadioButton();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecNacColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmpleadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDineroBase = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPanel.SuspendLayout();
            this.groupTipoEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDineroExtra)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDineroBase)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.groupTipoEmpleado);
            this.formPanel.Controls.Add(this.panel2);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 24);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(855, 167);
            this.formPanel.TabIndex = 1;
            this.formPanel.TabStop = false;
            this.formPanel.Text = "Empleado";
            // 
            // groupTipoEmpleado
            // 
            this.groupTipoEmpleado.Controls.Add(this.nudDineroBase);
            this.groupTipoEmpleado.Controls.Add(this.label4);
            this.groupTipoEmpleado.Controls.Add(this.btnBorrar);
            this.groupTipoEmpleado.Controls.Add(this.btnCancelar);
            this.groupTipoEmpleado.Controls.Add(this.btnGuardar);
            this.groupTipoEmpleado.Controls.Add(this.nudDineroExtra);
            this.groupTipoEmpleado.Controls.Add(this.lblDinero);
            this.groupTipoEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTipoEmpleado.Location = new System.Drawing.Point(364, 16);
            this.groupTipoEmpleado.Name = "groupTipoEmpleado";
            this.groupTipoEmpleado.Size = new System.Drawing.Size(488, 148);
            this.groupTipoEmpleado.TabIndex = 1;
            this.groupTipoEmpleado.TabStop = false;
            this.groupTipoEmpleado.Text = "Tipo de Empleado";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(171, 107);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(90, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 107);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudDineroExtra
            // 
            this.nudDineroExtra.DecimalPlaces = 2;
            this.nudDineroExtra.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDineroExtra.Location = new System.Drawing.Point(50, 74);
            this.nudDineroExtra.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudDineroExtra.Name = "nudDineroExtra";
            this.nudDineroExtra.Size = new System.Drawing.Size(120, 20);
            this.nudDineroExtra.TabIndex = 3;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(6, 77);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(38, 13);
            this.lblDinero.TabIndex = 2;
            this.lblDinero.Text = "Dinero";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioEmpleadoHonorarios);
            this.panel2.Controls.Add(this.radioEmpleadoFijo);
            this.panel2.Controls.Add(this.dtpFecNac);
            this.panel2.Controls.Add(this.tbxNombre);
            this.panel2.Controls.Add(this.nudID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 148);
            this.panel2.TabIndex = 0;
            // 
            // radioEmpleadoHonorarios
            // 
            this.radioEmpleadoHonorarios.AutoSize = true;
            this.radioEmpleadoHonorarios.Location = new System.Drawing.Point(139, 110);
            this.radioEmpleadoHonorarios.Name = "radioEmpleadoHonorarios";
            this.radioEmpleadoHonorarios.Size = new System.Drawing.Size(144, 17);
            this.radioEmpleadoHonorarios.TabIndex = 15;
            this.radioEmpleadoHonorarios.TabStop = true;
            this.radioEmpleadoHonorarios.Text = "Empleado por Honorarios";
            this.radioEmpleadoHonorarios.UseVisualStyleBackColor = true;
            this.radioEmpleadoHonorarios.CheckedChanged += new System.EventHandler(this.radioTipoEmpleado_CheckedChange);
            // 
            // radioEmpleadoFijo
            // 
            this.radioEmpleadoFijo.AutoSize = true;
            this.radioEmpleadoFijo.Location = new System.Drawing.Point(12, 110);
            this.radioEmpleadoFijo.Name = "radioEmpleadoFijo";
            this.radioEmpleadoFijo.Size = new System.Drawing.Size(91, 17);
            this.radioEmpleadoFijo.TabIndex = 14;
            this.radioEmpleadoFijo.TabStop = true;
            this.radioEmpleadoFijo.Text = "Empleado Fijo";
            this.radioEmpleadoFijo.UseVisualStyleBackColor = true;
            this.radioEmpleadoFijo.CheckedChanged += new System.EventHandler(this.radioTipoEmpleado_CheckedChange);
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(126, 74);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFecNac.TabIndex = 13;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(126, 41);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(200, 20);
            this.tbxNombre.TabIndex = 12;
            // 
            // nudID
            // 
            this.nudID.Enabled = false;
            this.nudID.Location = new System.Drawing.Point(126, 9);
            this.nudID.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(93, 20);
            this.nudID.TabIndex = 11;
            this.nudID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dgvEmpleados);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 191);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(855, 132);
            this.gridPanel.TabIndex = 2;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NombreColumn,
            this.FecNacColumn,
            this.TipoEmpleadoColumn});
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(855, 132);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // IDColumn
            // 
            this.IDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // NombreColumn
            // 
            this.NombreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // FecNacColumn
            // 
            this.FecNacColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FecNacColumn.HeaderText = "Fecha de Nacimiento";
            this.FecNacColumn.Name = "FecNacColumn";
            this.FecNacColumn.ReadOnly = true;
            // 
            // TipoEmpleadoColumn
            // 
            this.TipoEmpleadoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoEmpleadoColumn.HeaderText = "Tipo de Empleado";
            this.TipoEmpleadoColumn.Name = "TipoEmpleadoColumn";
            this.TipoEmpleadoColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salario Base:";
            // 
            // nudDineroBase
            // 
            this.nudDineroBase.DecimalPlaces = 2;
            this.nudDineroBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDineroBase.Location = new System.Drawing.Point(81, 41);
            this.nudDineroBase.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDineroBase.Name = "nudDineroBase";
            this.nudDineroBase.Size = new System.Drawing.Size(120, 20);
            this.nudDineroBase.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.emp";
            this.openFileDialog.FileName = "misempleados.emp";
            this.openFileDialog.Filter = "Archivos de Empleados|*.emp";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "*.emp";
            this.saveFileDialog.FileName = "misempleados.emp";
            this.saveFileDialog.Filter = "Archivos de Empleados|*.emp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 323);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "App Control de Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formPanel.ResumeLayout(false);
            this.groupTipoEmpleado.ResumeLayout(false);
            this.groupTipoEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDineroExtra)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDineroBase)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox formPanel;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.GroupBox groupTipoEmpleado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudDineroExtra;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioEmpleadoHonorarios;
        private System.Windows.Forms.RadioButton radioEmpleadoFijo;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecNacColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpleadoColumn;
        private System.Windows.Forms.NumericUpDown nudDineroBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

