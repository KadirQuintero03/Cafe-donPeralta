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
            this.dataGridView1.Location = new System.Drawing.Point(104, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // C_idnomina
            // 
            this.C_idnomina.HeaderText = "N°Pago";
            this.C_idnomina.Name = "C_idnomina";
            this.C_idnomina.Width = 70;
            // 
            // C_cedulaE
            // 
            this.C_cedulaE.HeaderText = "Cedula";
            this.C_cedulaE.Name = "C_cedulaE";
            // 
            // C_nombreE
            // 
            this.C_nombreE.HeaderText = "Nombre";
            this.C_nombreE.Name = "C_nombreE";
            // 
            // C_apellidoE
            // 
            this.C_apellidoE.HeaderText = "Apellido";
            this.C_apellidoE.Name = "C_apellidoE";
            // 
            // C_totalkilos
            // 
            this.C_totalkilos.HeaderText = "Kilos totales";
            this.C_totalkilos.Name = "C_totalkilos";
            // 
            // C_totalpedidos
            // 
            this.C_totalpedidos.HeaderText = "Pedidos totales";
            this.C_totalpedidos.Name = "C_totalpedidos";
            this.C_totalpedidos.Width = 110;
            // 
            // C_salariobase
            // 
            this.C_salariobase.HeaderText = "Salario Base";
            this.C_salariobase.Name = "C_salariobase";
            // 
            // C_totalpagar
            // 
            this.C_totalpagar.HeaderText = "Pago total";
            this.C_totalpagar.Name = "C_totalpagar";
            // 
            // txtFN_cedulaE
            // 
            this.txtFN_cedulaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtFN_cedulaE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFN_cedulaE.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtFN_cedulaE.Location = new System.Drawing.Point(232, 115);
            this.txtFN_cedulaE.Name = "txtFN_cedulaE";
            this.txtFN_cedulaE.Size = new System.Drawing.Size(137, 19);
            this.txtFN_cedulaE.TabIndex = 1;
            // 
            // txtFNvalordia
            // 
            this.txtFNvalordia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtFNvalordia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFNvalordia.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtFNvalordia.Location = new System.Drawing.Point(603, 115);
            this.txtFNvalordia.Name = "txtFNvalordia";
            this.txtFNvalordia.Size = new System.Drawing.Size(153, 19);
            this.txtFNvalordia.TabIndex = 3;
            // 
            // btn_FNregistrar
            // 
            this.btn_FNregistrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_FNregistrar.FlatAppearance.BorderSize = 0;
            this.btn_FNregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FNregistrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_FNregistrar.Location = new System.Drawing.Point(346, 206);
            this.btn_FNregistrar.Name = "btn_FNregistrar";
            this.btn_FNregistrar.Size = new System.Drawing.Size(88, 30);
            this.btn_FNregistrar.TabIndex = 4;
            this.btn_FNregistrar.Text = "Registrar";
            this.btn_FNregistrar.UseVisualStyleBackColor = false;
            // 
            // btn_FNpdf
            // 
            this.btn_FNpdf.BackColor = System.Drawing.Color.Transparent;
            this.btn_FNpdf.FlatAppearance.BorderSize = 0;
            this.btn_FNpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FNpdf.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_FNpdf.Location = new System.Drawing.Point(569, 206);
            this.btn_FNpdf.Name = "btn_FNpdf";
            this.btn_FNpdf.Size = new System.Drawing.Size(75, 28);
            this.btn_FNpdf.TabIndex = 5;
            this.btn_FNpdf.Text = "PDF";
            this.btn_FNpdf.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(407, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txt_FNcedulaA
            // 
            this.txt_FNcedulaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txt_FNcedulaA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FNcedulaA.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txt_FNcedulaA.Location = new System.Drawing.Point(417, 155);
            this.txt_FNcedulaA.Name = "txt_FNcedulaA";
            this.txt_FNcedulaA.Size = new System.Drawing.Size(145, 19);
            this.txt_FNcedulaA.TabIndex = 7;
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.NOMINA__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 505);
            this.Controls.Add(this.txt_FNcedulaA);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_FNpdf);
            this.Controls.Add(this.btn_FNregistrar);
            this.Controls.Add(this.txtFNvalordia);
            this.Controls.Add(this.txtFN_cedulaE);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Nomina";
            this.Text = "Nomina";
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
    }
}