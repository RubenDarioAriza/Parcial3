namespace Parcial3
{
    partial class FrmPrincipal
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
            this.dtgArchivos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSedeCargar = new System.Windows.Forms.ComboBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnGuardarBD = new System.Windows.Forms.Button();
            this.cmbSedeConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgBD = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarBD = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgArchivos
            // 
            this.dtgArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArchivos.Location = new System.Drawing.Point(14, 113);
            this.dtgArchivos.Name = "dtgArchivos";
            this.dtgArchivos.Size = new System.Drawing.Size(545, 247);
            this.dtgArchivos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sede:";
            // 
            // cmbSedeCargar
            // 
            this.cmbSedeCargar.FormattingEnabled = true;
            this.cmbSedeCargar.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cmbSedeCargar.Location = new System.Drawing.Point(74, 77);
            this.cmbSedeCargar.Name = "cmbSedeCargar";
            this.cmbSedeCargar.Size = new System.Drawing.Size(121, 21);
            this.cmbSedeCargar.TabIndex = 2;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(214, 75);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnCargarArchivo.TabIndex = 3;
            this.btnCargarArchivo.Text = "CARGAR";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardarBD
            // 
            this.btnGuardarBD.Location = new System.Drawing.Point(365, 75);
            this.btnGuardarBD.Name = "btnGuardarBD";
            this.btnGuardarBD.Size = new System.Drawing.Size(194, 23);
            this.btnGuardarBD.TabIndex = 4;
            this.btnGuardarBD.Text = "GUARDAR A BASE DE DATOS";
            this.btnGuardarBD.UseVisualStyleBackColor = true;
            this.btnGuardarBD.Click += new System.EventHandler(this.btnGuardarBD_Click);
            // 
            // cmbSedeConsulta
            // 
            this.cmbSedeConsulta.FormattingEnabled = true;
            this.cmbSedeConsulta.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cmbSedeConsulta.Location = new System.Drawing.Point(698, 77);
            this.cmbSedeConsulta.Name = "cmbSedeConsulta";
            this.cmbSedeConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbSedeConsulta.TabIndex = 7;
            this.cmbSedeConsulta.TextChanged += new System.EventHandler(this.cmbSedeConsulta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sede:";
            // 
            // dtgBD
            // 
            this.dtgBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBD.Location = new System.Drawing.Point(638, 113);
            this.dtgBD.Name = "dtgBD";
            this.dtgBD.Size = new System.Drawing.Size(545, 247);
            this.dtgBD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CARGA DE DATOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(866, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CONSULTA DE DATOS ";
            // 
            // btnCargarBD
            // 
            this.btnCargarBD.Location = new System.Drawing.Point(835, 75);
            this.btnCargarBD.Name = "btnCargarBD";
            this.btnCargarBD.Size = new System.Drawing.Size(75, 23);
            this.btnCargarBD.TabIndex = 10;
            this.btnCargarBD.Text = "CARGAR";
            this.btnCargarBD.UseVisualStyleBackColor = true;
            this.btnCargarBD.Click += new System.EventHandler(this.btnCargarBD_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(672, 38);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "CONSULTAR TODO";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 381);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCargarBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSedeConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgBD);
            this.Controls.Add(this.btnGuardarBD);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.cmbSedeCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgArchivos);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgArchivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSedeCargar;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnGuardarBD;
        private System.Windows.Forms.ComboBox cmbSedeConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarBD;
        private System.Windows.Forms.Button btnConsultar;
    }
}

