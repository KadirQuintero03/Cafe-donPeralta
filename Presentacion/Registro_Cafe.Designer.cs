namespace Presentacion
{
    partial class Registro_Cafe
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
            this.txtE_cedula_A2 = new System.Windows.Forms.TextBox();
            this.TxtKilosC = new System.Windows.Forms.TextBox();
            this.TxtKilosS = new System.Windows.Forms.TextBox();
            this.dataGridCafe = new System.Windows.Forms.DataGridView();
            this.btnregistrar_cafe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ColumNcafe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSecos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCerezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFechacafe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtE_cedula_A2
            // 
            this.txtE_cedula_A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtE_cedula_A2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtE_cedula_A2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.txtE_cedula_A2.Location = new System.Drawing.Point(344, 105);
            this.txtE_cedula_A2.Name = "txtE_cedula_A2";
            this.txtE_cedula_A2.Size = new System.Drawing.Size(112, 19);
            this.txtE_cedula_A2.TabIndex = 4;
            // 
            // TxtKilosC
            // 
            this.TxtKilosC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtKilosC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKilosC.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.TxtKilosC.Location = new System.Drawing.Point(431, 156);
            this.TxtKilosC.Name = "TxtKilosC";
            this.TxtKilosC.Size = new System.Drawing.Size(120, 19);
            this.TxtKilosC.TabIndex = 5;
            // 
            // TxtKilosS
            // 
            this.TxtKilosS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TxtKilosS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKilosS.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.TxtKilosS.Location = new System.Drawing.Point(262, 155);
            this.TxtKilosS.Name = "TxtKilosS";
            this.TxtKilosS.Size = new System.Drawing.Size(120, 19);
            this.TxtKilosS.TabIndex = 6;
            // 
            // dataGridCafe
            // 
            this.dataGridCafe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCafe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCafe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCafe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNcafe,
            this.ColumSecos,
            this.ColumCerezas,
            this.ColumFechacafe});
            this.dataGridCafe.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridCafe.Location = new System.Drawing.Point(120, 256);
            this.dataGridCafe.Name = "dataGridCafe";
            this.dataGridCafe.Size = new System.Drawing.Size(585, 171);
            this.dataGridCafe.TabIndex = 7;
            // 
            // btnregistrar_cafe
            // 
            this.btnregistrar_cafe.BackColor = System.Drawing.Color.Transparent;
            this.btnregistrar_cafe.FlatAppearance.BorderSize = 0;
            this.btnregistrar_cafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar_cafe.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnregistrar_cafe.Location = new System.Drawing.Point(280, 201);
            this.btnregistrar_cafe.Name = "btnregistrar_cafe";
            this.btnregistrar_cafe.Size = new System.Drawing.Size(87, 29);
            this.btnregistrar_cafe.TabIndex = 8;
            this.btnregistrar_cafe.Text = "Registrar";
            this.btnregistrar_cafe.UseVisualStyleBackColor = false;
            this.btnregistrar_cafe.Click += new System.EventHandler(this.btnregistrar_cafe_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(445, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ColumNcafe
            // 
            this.ColumNcafe.HeaderText = "N°Cafe ";
            this.ColumNcafe.Name = "ColumNcafe";
            this.ColumNcafe.Width = 60;
            // 
            // ColumSecos
            // 
            this.ColumSecos.HeaderText = "Secos Recolectados";
            this.ColumSecos.Name = "ColumSecos";
            this.ColumSecos.Width = 165;
            // 
            // ColumCerezas
            // 
            this.ColumCerezas.HeaderText = "Cerezas Recolectadas";
            this.ColumCerezas.Name = "ColumCerezas";
            this.ColumCerezas.Width = 165;
            // 
            // ColumFechacafe
            // 
            this.ColumFechacafe.HeaderText = "Fecha Registro ";
            this.ColumFechacafe.Name = "ColumFechacafe";
            this.ColumFechacafe.Width = 150;
            // 
            // Registro_Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Registrar_Cafes__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnregistrar_cafe);
            this.Controls.Add(this.dataGridCafe);
            this.Controls.Add(this.TxtKilosS);
            this.Controls.Add(this.TxtKilosC);
            this.Controls.Add(this.txtE_cedula_A2);
            this.DoubleBuffered = true;
            this.Name = "Registro_Cafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Cafe";
            this.Load += new System.EventHandler(this.Registro_Cafe_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_Cafe_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtE_cedula_A2;
        private System.Windows.Forms.TextBox TxtKilosC;
        private System.Windows.Forms.TextBox TxtKilosS;
        private System.Windows.Forms.DataGridView dataGridCafe;
        private System.Windows.Forms.Button btnregistrar_cafe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNcafe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumSecos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCerezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFechacafe;
    }
}