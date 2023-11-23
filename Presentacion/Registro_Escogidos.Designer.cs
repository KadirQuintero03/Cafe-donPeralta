namespace Presentacion
{
    partial class Registro_Escogidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtE_cedula_A3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.TxtCantEsco = new System.Windows.Forms.TextBox();
            this.FechaRegisEscogidos = new System.Windows.Forms.DateTimePicker();
            this.dataGridRegisEsc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegisEsCo = new System.Windows.Forms.Button();
            this.ColumNescogido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFechaeSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegisEsc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtE_cedula_A3
            // 
            this.txtE_cedula_A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_cedula_A3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_cedula_A3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtE_cedula_A3.Location = new System.Drawing.Point(254, 101);
            this.txtE_cedula_A3.Name = "txtE_cedula_A3";
            this.txtE_cedula_A3.Size = new System.Drawing.Size(109, 19);
            this.txtE_cedula_A3.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(80, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 22;
            // 
            // TxtCC
            // 
            this.TxtCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCC.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.TxtCC.Location = new System.Drawing.Point(251, 156);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(114, 19);
            this.TxtCC.TabIndex = 17;
            // 
            // TxtCantEsco
            // 
            this.TxtCantEsco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtCantEsco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCantEsco.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.TxtCantEsco.Location = new System.Drawing.Point(420, 100);
            this.TxtCantEsco.Name = "TxtCantEsco";
            this.TxtCantEsco.Size = new System.Drawing.Size(115, 19);
            this.TxtCantEsco.TabIndex = 19;
            // 
            // FechaRegisEscogidos
            // 
            this.FechaRegisEscogidos.Location = new System.Drawing.Point(416, 155);
            this.FechaRegisEscogidos.Name = "FechaRegisEscogidos";
            this.FechaRegisEscogidos.Size = new System.Drawing.Size(119, 20);
            this.FechaRegisEscogidos.TabIndex = 21;
            // 
            // dataGridRegisEsc
            // 
            this.dataGridRegisEsc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridRegisEsc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRegisEsc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRegisEsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegisEsc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNescogido,
            this.ColumCC,
            this.ColumCantidad,
            this.ColumFechaeSC});
            this.dataGridRegisEsc.Location = new System.Drawing.Point(112, 258);
            this.dataGridRegisEsc.Name = "dataGridRegisEsc";
            this.dataGridRegisEsc.RowHeadersWidth = 51;
            this.dataGridRegisEsc.Size = new System.Drawing.Size(578, 167);
            this.dataGridRegisEsc.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(429, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRegisEsCo
            // 
            this.btnRegisEsCo.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisEsCo.FlatAppearance.BorderSize = 0;
            this.btnRegisEsCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisEsCo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegisEsCo.Location = new System.Drawing.Point(270, 199);
            this.btnRegisEsCo.Name = "btnRegisEsCo";
            this.btnRegisEsCo.Size = new System.Drawing.Size(88, 32);
            this.btnRegisEsCo.TabIndex = 27;
            this.btnRegisEsCo.Text = "Registrar";
            this.btnRegisEsCo.UseVisualStyleBackColor = false;
            this.btnRegisEsCo.Click += new System.EventHandler(this.btnRegisEsCo_Click);
            // 
            // ColumNescogido
            // 
            this.ColumNescogido.HeaderText = "N°Escogido";
            this.ColumNescogido.Name = "ColumNescogido";
            // 
            // ColumCC
            // 
            this.ColumCC.HeaderText = "Cc Empleado";
            this.ColumCC.MinimumWidth = 6;
            this.ColumCC.Name = "ColumCC";
            this.ColumCC.ReadOnly = true;
            this.ColumCC.Width = 135;
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad Escogida";
            this.ColumCantidad.MinimumWidth = 6;
            this.ColumCantidad.Name = "ColumCantidad";
            this.ColumCantidad.ReadOnly = true;
            this.ColumCantidad.Width = 140;
            // 
            // ColumFechaeSC
            // 
            this.ColumFechaeSC.HeaderText = "Fecha Registro";
            this.ColumFechaeSC.MinimumWidth = 6;
            this.ColumFechaeSC.Name = "ColumFechaeSC";
            this.ColumFechaeSC.ReadOnly = true;
            this.ColumFechaeSC.Width = 150;
            // 
            // Registro_Escogidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Registrar_Cafes__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegisEsCo);
            this.Controls.Add(this.dataGridRegisEsc);
            this.Controls.Add(this.txtE_cedula_A3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtCC);
            this.Controls.Add(this.TxtCantEsco);
            this.Controls.Add(this.FechaRegisEscogidos);
            this.DoubleBuffered = true;
            this.Name = "Registro_Escogidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Escogidos";
            this.Load += new System.EventHandler(this.Registro_Escogidos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_Escogidos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegisEsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtE_cedula_A3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.TextBox TxtCantEsco;
        private System.Windows.Forms.DateTimePicker FechaRegisEscogidos;
        private System.Windows.Forms.DataGridView dataGridRegisEsc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegisEsCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNescogido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFechaeSC;
    }
}