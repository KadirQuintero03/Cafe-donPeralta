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
            this.c = new System.Windows.Forms.DataGridView();
            this.ColumNescogido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFechaeSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPdfEscogidos = new System.Windows.Forms.Button();
            this.btnRegisEsCo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            this.SuspendLayout();
            // 
            // txtE_cedula_A3
            // 
            this.txtE_cedula_A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_cedula_A3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_cedula_A3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtE_cedula_A3.Location = new System.Drawing.Point(339, 124);
            this.txtE_cedula_A3.Margin = new System.Windows.Forms.Padding(4);
            this.txtE_cedula_A3.Name = "txtE_cedula_A3";
            this.txtE_cedula_A3.Size = new System.Drawing.Size(145, 23);
            this.txtE_cedula_A3.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 55);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 16);
            this.label18.TabIndex = 22;
            // 
            // TxtCC
            // 
            this.TxtCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCC.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.TxtCC.Location = new System.Drawing.Point(335, 192);
            this.TxtCC.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(152, 23);
            this.TxtCC.TabIndex = 17;
            // 
            // TxtCantEsco
            // 
            this.TxtCantEsco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtCantEsco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCantEsco.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.TxtCantEsco.Location = new System.Drawing.Point(560, 123);
            this.TxtCantEsco.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantEsco.Name = "TxtCantEsco";
            this.TxtCantEsco.Size = new System.Drawing.Size(153, 23);
            this.TxtCantEsco.TabIndex = 19;
            // 
            // FechaRegisEscogidos
            // 
            this.FechaRegisEscogidos.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRegisEscogidos.Location = new System.Drawing.Point(555, 191);
            this.FechaRegisEscogidos.Margin = new System.Windows.Forms.Padding(4);
            this.FechaRegisEscogidos.Name = "FechaRegisEscogidos";
            this.FechaRegisEscogidos.Size = new System.Drawing.Size(157, 29);
            this.FechaRegisEscogidos.TabIndex = 21;
            // 
            // c
            // 
            this.c.BackgroundColor = System.Drawing.SystemColors.Window;
            this.c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.c.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.c.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNescogido,
            this.ColumCC,
            this.ColumCantidad,
            this.ColumFechaeSC});
            this.c.Location = new System.Drawing.Point(149, 318);
            this.c.Margin = new System.Windows.Forms.Padding(4);
            this.c.Name = "c";
            this.c.RowHeadersWidth = 51;
            this.c.Size = new System.Drawing.Size(771, 206);
            this.c.TabIndex = 26;
            // 
            // ColumNescogido
            // 
            this.ColumNescogido.HeaderText = "N°Escogido";
            this.ColumNescogido.MinimumWidth = 6;
            this.ColumNescogido.Name = "ColumNescogido";
            this.ColumNescogido.Width = 125;
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
            // btnPdfEscogidos
            // 
            this.btnPdfEscogidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPdfEscogidos.FlatAppearance.BorderSize = 0;
            this.btnPdfEscogidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfEscogidos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPdfEscogidos.Location = new System.Drawing.Point(572, 242);
            this.btnPdfEscogidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPdfEscogidos.Name = "btnPdfEscogidos";
            this.btnPdfEscogidos.Size = new System.Drawing.Size(123, 43);
            this.btnPdfEscogidos.TabIndex = 28;
            this.btnPdfEscogidos.Text = "PDF";
            this.btnPdfEscogidos.UseVisualStyleBackColor = false;
            this.btnPdfEscogidos.Click += new System.EventHandler(this.btnPdfEscogidos_Click);
            // 
            // btnRegisEsCo
            // 
            this.btnRegisEsCo.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisEsCo.FlatAppearance.BorderSize = 0;
            this.btnRegisEsCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisEsCo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegisEsCo.Location = new System.Drawing.Point(360, 245);
            this.btnRegisEsCo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisEsCo.Name = "btnRegisEsCo";
            this.btnRegisEsCo.Size = new System.Drawing.Size(117, 39);
            this.btnRegisEsCo.TabIndex = 27;
            this.btnRegisEsCo.Text = "Registrar";
            this.btnRegisEsCo.UseVisualStyleBackColor = false;
            this.btnRegisEsCo.Click += new System.EventHandler(this.btnRegisEsCo_Click);
            // 
            // Registro_Escogidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Registrar_Cafes__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPdfEscogidos);
            this.Controls.Add(this.btnRegisEsCo);
            this.Controls.Add(this.c);
            this.Controls.Add(this.txtE_cedula_A3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtCC);
            this.Controls.Add(this.TxtCantEsco);
            this.Controls.Add(this.FechaRegisEscogidos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registro_Escogidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Escogidos";
            this.Load += new System.EventHandler(this.Registro_Escogidos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_Escogidos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtE_cedula_A3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.TextBox TxtCantEsco;
        private System.Windows.Forms.DateTimePicker FechaRegisEscogidos;
        private System.Windows.Forms.DataGridView c;
        private System.Windows.Forms.Button btnPdfEscogidos;
        private System.Windows.Forms.Button btnRegisEsCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNescogido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFechaeSC;
    }
}