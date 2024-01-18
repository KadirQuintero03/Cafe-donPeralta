namespace Presentacion
{
    partial class Manejo_Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtE_cedula_A = new System.Windows.Forms.TextBox();
            this.BtnEliminarEmp = new System.Windows.Forms.Button();
            this.BtnModificarEmp = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleados = new System.Windows.Forms.Button();
            this.dataGridEmpleado = new System.Windows.Forms.DataGridView();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtE_apellido2 = new System.Windows.Forms.TextBox();
            this.txtE_apellido = new System.Windows.Forms.TextBox();
            this.txtE_nombre2 = new System.Windows.Forms.TextBox();
            this.txtE_nombre = new System.Windows.Forms.TextBox();
            this.txtE_cedula = new System.Windows.Forms.TextBox();
            this.txtbusquedaE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtE_cedula_A
            // 
            this.txtE_cedula_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_cedula_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_cedula_A.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtE_cedula_A.Location = new System.Drawing.Point(46, 147);
            this.txtE_cedula_A.Name = "txtE_cedula_A";
            this.txtE_cedula_A.Size = new System.Drawing.Size(134, 19);
            this.txtE_cedula_A.TabIndex = 30;
            // 
            // BtnEliminarEmp
            // 
            this.BtnEliminarEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarEmp.FlatAppearance.BorderSize = 0;
            this.BtnEliminarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarEmp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnEliminarEmp.Location = new System.Drawing.Point(405, 190);
            this.BtnEliminarEmp.Name = "BtnEliminarEmp";
            this.BtnEliminarEmp.Size = new System.Drawing.Size(88, 25);
            this.BtnEliminarEmp.TabIndex = 27;
            this.BtnEliminarEmp.Text = "Eliminar";
            this.BtnEliminarEmp.UseVisualStyleBackColor = false;
            this.BtnEliminarEmp.Click += new System.EventHandler(this.BtnEliminarEmp_Click);
            // 
            // BtnModificarEmp
            // 
            this.BtnModificarEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarEmp.FlatAppearance.BorderSize = 0;
            this.BtnModificarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarEmp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnModificarEmp.Location = new System.Drawing.Point(244, 190);
            this.BtnModificarEmp.Name = "BtnModificarEmp";
            this.BtnModificarEmp.Size = new System.Drawing.Size(93, 25);
            this.BtnModificarEmp.TabIndex = 26;
            this.BtnModificarEmp.Text = "Modificar";
            this.BtnModificarEmp.UseVisualStyleBackColor = false;
            this.BtnModificarEmp.Click += new System.EventHandler(this.BtnModificarEmp_Click);
            // 
            // btnRegistrarEmpleados
            // 
            this.btnRegistrarEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegistrarEmpleados.Location = new System.Drawing.Point(68, 188);
            this.btnRegistrarEmpleados.Name = "btnRegistrarEmpleados";
            this.btnRegistrarEmpleados.Size = new System.Drawing.Size(88, 31);
            this.btnRegistrarEmpleados.TabIndex = 25;
            this.btnRegistrarEmpleados.Text = "Registrar";
            this.btnRegistrarEmpleados.UseVisualStyleBackColor = false;
            this.btnRegistrarEmpleados.Click += new System.EventHandler(this.btnRegistrarEmpleados_Click_1);
            // 
            // dataGridEmpleado
            // 
            this.dataGridEmpleado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumID,
            this.ColumPN,
            this.ColumSn,
            this.ColumPA,
            this.ColumSA,
            this.ColumnFecha});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmpleado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEmpleado.Location = new System.Drawing.Point(40, 258);
            this.dataGridEmpleado.Name = "dataGridEmpleado";
            this.dataGridEmpleado.RowHeadersWidth = 51;
            this.dataGridEmpleado.Size = new System.Drawing.Size(793, 234);
            this.dataGridEmpleado.TabIndex = 28;
            // 
            // ColumID
            // 
            this.ColumID.HeaderText = "Cedula";
            this.ColumID.MinimumWidth = 6;
            this.ColumID.Name = "ColumID";
            this.ColumID.ReadOnly = true;
            this.ColumID.Width = 120;
            // 
            // ColumPN
            // 
            this.ColumPN.HeaderText = "Nombre";
            this.ColumPN.MinimumWidth = 6;
            this.ColumPN.Name = "ColumPN";
            this.ColumPN.ReadOnly = true;
            // 
            // ColumSn
            // 
            this.ColumSn.HeaderText = "Segundo Nombre";
            this.ColumSn.MinimumWidth = 6;
            this.ColumSn.Name = "ColumSn";
            this.ColumSn.ReadOnly = true;
            this.ColumSn.Width = 140;
            // 
            // ColumPA
            // 
            this.ColumPA.HeaderText = "Apellido";
            this.ColumPA.MinimumWidth = 6;
            this.ColumPA.Name = "ColumPA";
            this.ColumPA.ReadOnly = true;
            // 
            // ColumSA
            // 
            this.ColumSA.HeaderText = "Segundo Apellido";
            this.ColumSA.MinimumWidth = 6;
            this.ColumSA.Name = "ColumSA";
            this.ColumSA.ReadOnly = true;
            this.ColumSA.Width = 150;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha Inicio";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.Width = 130;
            // 
            // txtE_apellido2
            // 
            this.txtE_apellido2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_apellido2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_apellido2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtE_apellido2.Location = new System.Drawing.Point(385, 147);
            this.txtE_apellido2.Name = "txtE_apellido2";
            this.txtE_apellido2.Size = new System.Drawing.Size(134, 19);
            this.txtE_apellido2.TabIndex = 23;
            // 
            // txtE_apellido
            // 
            this.txtE_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_apellido.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtE_apellido.Location = new System.Drawing.Point(385, 80);
            this.txtE_apellido.Name = "txtE_apellido";
            this.txtE_apellido.Size = new System.Drawing.Size(134, 19);
            this.txtE_apellido.TabIndex = 21;
            // 
            // txtE_nombre2
            // 
            this.txtE_nombre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_nombre2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_nombre2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtE_nombre2.Location = new System.Drawing.Point(219, 147);
            this.txtE_nombre2.Name = "txtE_nombre2";
            this.txtE_nombre2.Size = new System.Drawing.Size(134, 19);
            this.txtE_nombre2.TabIndex = 19;
            // 
            // txtE_nombre
            // 
            this.txtE_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_nombre.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtE_nombre.Location = new System.Drawing.Point(219, 80);
            this.txtE_nombre.Name = "txtE_nombre";
            this.txtE_nombre.Size = new System.Drawing.Size(134, 19);
            this.txtE_nombre.TabIndex = 17;
            // 
            // txtE_cedula
            // 
            this.txtE_cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_cedula.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE_cedula.Location = new System.Drawing.Point(46, 80);
            this.txtE_cedula.Name = "txtE_cedula";
            this.txtE_cedula.Size = new System.Drawing.Size(134, 19);
            this.txtE_cedula.TabIndex = 15;
            // 
            // txtbusquedaE
            // 
            this.txtbusquedaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtbusquedaE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbusquedaE.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtbusquedaE.Location = new System.Drawing.Point(633, 197);
            this.txtbusquedaE.Name = "txtbusquedaE";
            this.txtbusquedaE.Size = new System.Drawing.Size(145, 19);
            this.txtbusquedaE.TabIndex = 31;
            this.txtbusquedaE.TextChanged += new System.EventHandler(this.txtbusquedaE_TextChanged);
            // 
            // Manejo_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Registrar_Cafes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 514);
            this.Controls.Add(this.txtbusquedaE);
            this.Controls.Add(this.txtE_cedula_A);
            this.Controls.Add(this.BtnEliminarEmp);
            this.Controls.Add(this.BtnModificarEmp);
            this.Controls.Add(this.btnRegistrarEmpleados);
            this.Controls.Add(this.dataGridEmpleado);
            this.Controls.Add(this.txtE_apellido2);
            this.Controls.Add(this.txtE_apellido);
            this.Controls.Add(this.txtE_nombre2);
            this.Controls.Add(this.txtE_nombre);
            this.Controls.Add(this.txtE_cedula);
            this.Name = "Manejo_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo_Empleados";
            this.Load += new System.EventHandler(this.Manejo_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtE_cedula_A;
        private System.Windows.Forms.Button BtnEliminarEmp;
        private System.Windows.Forms.Button BtnModificarEmp;
        private System.Windows.Forms.Button btnRegistrarEmpleados;
        private System.Windows.Forms.DataGridView dataGridEmpleado;
        private System.Windows.Forms.TextBox txtE_apellido2;
        private System.Windows.Forms.TextBox txtE_apellido;
        private System.Windows.Forms.TextBox txtE_nombre2;
        private System.Windows.Forms.TextBox txtE_nombre;
        private System.Windows.Forms.TextBox txtE_cedula;
        private System.Windows.Forms.TextBox txtbusquedaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumSn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
    }
}