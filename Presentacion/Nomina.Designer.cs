namespace Presentacion
{
    partial class Nomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_idnomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_cedulaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_apellidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_totalkilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_totalpedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_salariobase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_totalpagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFN_cedulaE = new System.Windows.Forms.TextBox();
            this.txtFNvalordia = new System.Windows.Forms.TextBox();
            this.btn_FNregistrar = new System.Windows.Forms.Button();
            this.btn_FNpdf = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_FNcedulaA = new System.Windows.Forms.TextBox();
            this.txtPdfN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_idnomina,
            this.C_cedulaE,
            this.C_nombreE,
            this.C_apellidoE,
            this.C_totalkilos,
            this.C_totalpedidos,
            this.C_salariobase,
            this.C_totalpagar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(139, 326);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // C_idnomina
            // 
            this.C_idnomina.HeaderText = "N°Pago";
            this.C_idnomina.MinimumWidth = 6;
            this.C_idnomina.Name = "C_idnomina";
            this.C_idnomina.Width = 70;
            // 
            // C_cedulaE
            // 
            this.C_cedulaE.HeaderText = "Cedula";
            this.C_cedulaE.MinimumWidth = 6;
            this.C_cedulaE.Name = "C_cedulaE";
            this.C_cedulaE.Width = 125;
            // 
            // C_nombreE
            // 
            this.C_nombreE.HeaderText = "Nombre";
            this.C_nombreE.MinimumWidth = 6;
            this.C_nombreE.Name = "C_nombreE";
            this.C_nombreE.Width = 125;
            // 
            // C_apellidoE
            // 
            this.C_apellidoE.HeaderText = "Apellido";
            this.C_apellidoE.MinimumWidth = 6;
            this.C_apellidoE.Name = "C_apellidoE";
            this.C_apellidoE.Width = 125;
            // 
            // C_totalkilos
            // 
            this.C_totalkilos.HeaderText = "Kilos totales";
            this.C_totalkilos.MinimumWidth = 6;
            this.C_totalkilos.Name = "C_totalkilos";
            this.C_totalkilos.Width = 125;
            // 
            // C_totalpedidos
            // 
            this.C_totalpedidos.HeaderText = "Pedidos totales";
            this.C_totalpedidos.MinimumWidth = 6;
            this.C_totalpedidos.Name = "C_totalpedidos";
            this.C_totalpedidos.Width = 110;
            // 
            // C_salariobase
            // 
            this.C_salariobase.HeaderText = "Salario Base";
            this.C_salariobase.MinimumWidth = 6;
            this.C_salariobase.Name = "C_salariobase";
            this.C_salariobase.Width = 125;
            // 
            // C_totalpagar
            // 
            this.C_totalpagar.HeaderText = "Pago total";
            this.C_totalpagar.MinimumWidth = 6;
            this.C_totalpagar.Name = "C_totalpagar";
            this.C_totalpagar.Width = 125;
            // 
            // txtFN_cedulaE
            // 
            this.txtFN_cedulaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtFN_cedulaE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFN_cedulaE.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtFN_cedulaE.Location = new System.Drawing.Point(309, 142);
            this.txtFN_cedulaE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFN_cedulaE.Name = "txtFN_cedulaE";
            this.txtFN_cedulaE.Size = new System.Drawing.Size(183, 23);
            this.txtFN_cedulaE.TabIndex = 1;
            // 
            // txtFNvalordia
            // 
            this.txtFNvalordia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtFNvalordia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFNvalordia.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtFNvalordia.Location = new System.Drawing.Point(804, 142);
            this.txtFNvalordia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFNvalordia.Name = "txtFNvalordia";
            this.txtFNvalordia.Size = new System.Drawing.Size(204, 23);
            this.txtFNvalordia.TabIndex = 3;
            // 
            // btn_FNregistrar
            // 
            this.btn_FNregistrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_FNregistrar.FlatAppearance.BorderSize = 0;
            this.btn_FNregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FNregistrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_FNregistrar.Location = new System.Drawing.Point(461, 254);
            this.btn_FNregistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FNregistrar.Name = "btn_FNregistrar";
            this.btn_FNregistrar.Size = new System.Drawing.Size(117, 37);
            this.btn_FNregistrar.TabIndex = 4;
            this.btn_FNregistrar.Text = "Registrar";
            this.btn_FNregistrar.UseVisualStyleBackColor = false;
            this.btn_FNregistrar.Click += new System.EventHandler(this.btn_FNregistrar_Click);
            // 
            // btn_FNpdf
            // 
            this.btn_FNpdf.BackColor = System.Drawing.Color.Transparent;
            this.btn_FNpdf.FlatAppearance.BorderSize = 0;
            this.btn_FNpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FNpdf.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_FNpdf.Location = new System.Drawing.Point(759, 257);
            this.btn_FNpdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FNpdf.Name = "btn_FNpdf";
            this.btn_FNpdf.Size = new System.Drawing.Size(100, 34);
            this.btn_FNpdf.TabIndex = 5;
            this.btn_FNpdf.Text = "PDF";
            this.btn_FNpdf.UseVisualStyleBackColor = false;
            this.btn_FNpdf.Click += new System.EventHandler(this.btn_FNpdf_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(543, 140);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txt_FNcedulaA
            // 
            this.txt_FNcedulaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txt_FNcedulaA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FNcedulaA.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txt_FNcedulaA.Location = new System.Drawing.Point(556, 191);
            this.txt_FNcedulaA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_FNcedulaA.Name = "txt_FNcedulaA";
            this.txt_FNcedulaA.Size = new System.Drawing.Size(193, 23);
            this.txt_FNcedulaA.TabIndex = 7;
            // 
            // txtPdfN
            // 
            this.txtPdfN.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPdfN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPdfN.Location = new System.Drawing.Point(907, 269);
            this.txtPdfN.Name = "txtPdfN";
            this.txtPdfN.Size = new System.Drawing.Size(149, 15);
            this.txtPdfN.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(938, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cedula";
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.NOMINA__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1373, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPdfN);
            this.Controls.Add(this.txt_FNcedulaA);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_FNpdf);
            this.Controls.Add(this.btn_FNregistrar);
            this.Controls.Add(this.txtFNvalordia);
            this.Controls.Add(this.txtFN_cedulaE);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFN_cedulaE;
        private System.Windows.Forms.TextBox txtFNvalordia;
        private System.Windows.Forms.Button btn_FNregistrar;
        private System.Windows.Forms.Button btn_FNpdf;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_idnomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_cedulaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_apellidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_totalkilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_totalpedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_salariobase;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_totalpagar;
        private System.Windows.Forms.TextBox txt_FNcedulaA;
        private System.Windows.Forms.TextBox txtPdfN;
        private System.Windows.Forms.Label label1;
    }
}