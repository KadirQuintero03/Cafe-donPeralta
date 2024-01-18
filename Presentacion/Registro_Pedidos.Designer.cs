namespace Presentacion
{
    partial class Registro_Pedidos
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
            this.btn_crearfacturaP = new System.Windows.Forms.Button();
            this.btn_agregarP = new System.Windows.Forms.Button();
            this.txtCantidadPe = new System.Windows.Forms.TextBox();
            this.txtRefPro = new System.Windows.Forms.TextBox();
            this.txtCePe = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Idpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_apellidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNfacturaP = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtRefFacturaP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crearfacturaP
            // 
            this.btn_crearfacturaP.BackColor = System.Drawing.Color.Transparent;
            this.btn_crearfacturaP.FlatAppearance.BorderSize = 0;
            this.btn_crearfacturaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearfacturaP.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_crearfacturaP.Location = new System.Drawing.Point(879, 108);
            this.btn_crearfacturaP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_crearfacturaP.Name = "btn_crearfacturaP";
            this.btn_crearfacturaP.Size = new System.Drawing.Size(124, 34);
            this.btn_crearfacturaP.TabIndex = 21;
            this.btn_crearfacturaP.Text = "Crear";
            this.btn_crearfacturaP.UseVisualStyleBackColor = false;
            this.btn_crearfacturaP.Click += new System.EventHandler(this.btn_crearfacturaP_Click);
            // 
            // btn_agregarP
            // 
            this.btn_agregarP.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarP.FlatAppearance.BorderSize = 0;
            this.btn_agregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarP.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_agregarP.Location = new System.Drawing.Point(1103, 219);
            this.btn_agregarP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregarP.Name = "btn_agregarP";
            this.btn_agregarP.Size = new System.Drawing.Size(116, 34);
            this.btn_agregarP.TabIndex = 20;
            this.btn_agregarP.Text = "Registrar";
            this.btn_agregarP.UseVisualStyleBackColor = false;
            this.btn_agregarP.Click += new System.EventHandler(this.btn_agregarP_Click);
            // 
            // txtCantidadPe
            // 
            this.txtCantidadPe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCantidadPe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadPe.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtCantidadPe.Location = new System.Drawing.Point(869, 228);
            this.txtCantidadPe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadPe.Name = "txtCantidadPe";
            this.txtCantidadPe.Size = new System.Drawing.Size(168, 23);
            this.txtCantidadPe.TabIndex = 15;
            // 
            // txtRefPro
            // 
            this.txtRefPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtRefPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRefPro.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtRefPro.Location = new System.Drawing.Point(623, 228);
            this.txtRefPro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRefPro.Name = "txtRefPro";
            this.txtRefPro.Size = new System.Drawing.Size(168, 23);
            this.txtRefPro.TabIndex = 13;
            // 
            // txtCePe
            // 
            this.txtCePe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCePe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCePe.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtCePe.Location = new System.Drawing.Point(377, 228);
            this.txtCePe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCePe.Name = "txtCePe";
            this.txtCePe.Size = new System.Drawing.Size(168, 23);
            this.txtCePe.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Idpedido,
            this.C_nombreP,
            this.C_nombreE,
            this.C_apellidoE,
            this.C_total,
            this.C_fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(107, 313);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(963, 244);
            this.dataGridView1.TabIndex = 11;
            // 
            // C_Idpedido
            // 
            this.C_Idpedido.HeaderText = "N°Pedido";
            this.C_Idpedido.MinimumWidth = 6;
            this.C_Idpedido.Name = "C_Idpedido";
            this.C_Idpedido.Width = 80;
            // 
            // C_nombreP
            // 
            this.C_nombreP.HeaderText = "Pedido";
            this.C_nombreP.MinimumWidth = 6;
            this.C_nombreP.Name = "C_nombreP";
            this.C_nombreP.Width = 120;
            // 
            // C_nombreE
            // 
            this.C_nombreE.HeaderText = "Nombre";
            this.C_nombreE.MinimumWidth = 6;
            this.C_nombreE.Name = "C_nombreE";
            this.C_nombreE.Width = 120;
            // 
            // C_apellidoE
            // 
            this.C_apellidoE.HeaderText = "Apellido";
            this.C_apellidoE.MinimumWidth = 6;
            this.C_apellidoE.Name = "C_apellidoE";
            this.C_apellidoE.Width = 120;
            // 
            // C_total
            // 
            this.C_total.HeaderText = "Total a pagar";
            this.C_total.MinimumWidth = 6;
            this.C_total.Name = "C_total";
            this.C_total.Width = 120;
            // 
            // C_fecha
            // 
            this.C_fecha.HeaderText = "Fecha Pedido";
            this.C_fecha.MinimumWidth = 6;
            this.C_fecha.Name = "C_fecha";
            this.C_fecha.Width = 120;
            // 
            // txtNfacturaP
            // 
            this.txtNfacturaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNfacturaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNfacturaP.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtNfacturaP.Location = new System.Drawing.Point(303, 123);
            this.txtNfacturaP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNfacturaP.Name = "txtNfacturaP";
            this.txtNfacturaP.Size = new System.Drawing.Size(168, 23);
            this.txtNfacturaP.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(597, 117);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 30);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // txtRefFacturaP
            // 
            this.txtRefFacturaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtRefFacturaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRefFacturaP.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtRefFacturaP.Location = new System.Drawing.Point(139, 226);
            this.txtRefFacturaP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRefFacturaP.Name = "txtRefFacturaP";
            this.txtRefFacturaP.Size = new System.Drawing.Size(168, 23);
            this.txtRefFacturaP.TabIndex = 27;
            // 
            // Registro_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.PEDIDOS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 588);
            this.Controls.Add(this.txtRefFacturaP);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNfacturaP);
            this.Controls.Add(this.btn_crearfacturaP);
            this.Controls.Add(this.btn_agregarP);
            this.Controls.Add(this.txtCantidadPe);
            this.Controls.Add(this.txtRefPro);
            this.Controls.Add(this.txtCePe);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro_Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Pedidos";
            this.Load += new System.EventHandler(this.Registro_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crearfacturaP;
        private System.Windows.Forms.Button btn_agregarP;
        private System.Windows.Forms.TextBox txtCantidadPe;
        private System.Windows.Forms.TextBox txtRefPro;
        private System.Windows.Forms.TextBox txtCePe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNfacturaP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtRefFacturaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Idpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_apellidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_fecha;
    }
}