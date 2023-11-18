namespace prySosaTP
{
    partial class frmListado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.lblBuscarApellido = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCiu = new System.Windows.Forms.TextBox();
            this.lblBuscarCiu = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnCancelarBarrio = new System.Windows.Forms.Button();
            this.btnBuscarBarrio = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(41, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(317, 119);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnCancelar);
            this.tabPage1.Controls.Add(this.txtBuscarApellido);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lblBuscarApellido);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(309, 93);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apellido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(82, 24);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(207, 20);
            this.txtBuscarApellido.TabIndex = 1;
            // 
            // lblBuscarApellido
            // 
            this.lblBuscarApellido.AutoSize = true;
            this.lblBuscarApellido.Location = new System.Drawing.Point(19, 27);
            this.lblBuscarApellido.Name = "lblBuscarApellido";
            this.lblBuscarApellido.Size = new System.Drawing.Size(47, 13);
            this.lblBuscarApellido.TabIndex = 0;
            this.lblBuscarApellido.Text = "Apellido:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelarBarrio);
            this.tabPage2.Controls.Add(this.btnBuscarBarrio);
            this.tabPage2.Controls.Add(this.txtCiu);
            this.tabPage2.Controls.Add(this.lblBuscarCiu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(309, 93);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barrio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCiu
            // 
            this.txtCiu.Location = new System.Drawing.Point(80, 31);
            this.txtCiu.Name = "txtCiu";
            this.txtCiu.Size = new System.Drawing.Size(186, 20);
            this.txtCiu.TabIndex = 2;
            // 
            // lblBuscarCiu
            // 
            this.lblBuscarCiu.AutoSize = true;
            this.lblBuscarCiu.Location = new System.Drawing.Point(21, 34);
            this.lblBuscarCiu.Name = "lblBuscarCiu";
            this.lblBuscarCiu.Size = new System.Drawing.Size(37, 13);
            this.lblBuscarCiu.TabIndex = 1;
            this.lblBuscarCiu.Text = "Barrio:";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(41, 180);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(313, 231);
            this.dgvGrilla.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(214, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(119, 50);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnCancelarBarrio
            // 
            this.btnCancelarBarrio.Location = new System.Drawing.Point(96, 57);
            this.btnCancelarBarrio.Name = "btnCancelarBarrio";
            this.btnCancelarBarrio.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBarrio.TabIndex = 5;
            this.btnCancelarBarrio.Text = "Cancelar";
            this.btnCancelarBarrio.UseVisualStyleBackColor = true;
            // 
            // btnBuscarBarrio
            // 
            this.btnBuscarBarrio.Location = new System.Drawing.Point(191, 57);
            this.btnBuscarBarrio.Name = "btnBuscarBarrio";
            this.btnBuscarBarrio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBarrio.TabIndex = 4;
            this.btnBuscarBarrio.Text = "Buscar";
            this.btnBuscarBarrio.UseVisualStyleBackColor = true;
            this.btnBuscarBarrio.Click += new System.EventHandler(this.btnBuscarBarrio_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO EMPLEADOS";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.Label lblBuscarApellido;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCiu;
        private System.Windows.Forms.Label lblBuscarCiu;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnCancelarBarrio;
        private System.Windows.Forms.Button btnBuscarBarrio;
    }
}