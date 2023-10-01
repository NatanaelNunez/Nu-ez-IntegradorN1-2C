namespace Nuñez_IntegradorN1_2C
{
    partial class FrmCalculadora
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
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblPrimerOperador = new System.Windows.Forms.Label();
            this.lblSegundoOperador = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpSistema = new System.Windows.Forms.GroupBox();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.rdbBinario = new System.Windows.Forms.RadioButton();
            this.txtSegundoOperando = new System.Windows.Forms.TextBox();
            this.txtPrimerOperando = new System.Windows.Forms.TextBox();
            this.grpSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(220, 251);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOperacion.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacion.TabIndex = 0;
            this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(454, 305);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(230, 305);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Enabled = false;
            this.btnOperar.Location = new System.Drawing.Point(47, 305);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(252, 229);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(56, 13);
            this.lblOperacion.TabIndex = 4;
            this.lblOperacion.Text = "Operacion";
            // 
            // lblPrimerOperador
            // 
            this.lblPrimerOperador.AutoSize = true;
            this.lblPrimerOperador.Location = new System.Drawing.Point(47, 229);
            this.lblPrimerOperador.Name = "lblPrimerOperador";
            this.lblPrimerOperador.Size = new System.Drawing.Size(80, 13);
            this.lblPrimerOperador.TabIndex = 5;
            this.lblPrimerOperador.Text = "PrimerOperador";
            // 
            // lblSegundoOperador
            // 
            this.lblSegundoOperador.AutoSize = true;
            this.lblSegundoOperador.Location = new System.Drawing.Point(438, 229);
            this.lblSegundoOperador.Name = "lblSegundoOperador";
            this.lblSegundoOperador.Size = new System.Drawing.Size(94, 13);
            this.lblSegundoOperador.TabIndex = 6;
            this.lblSegundoOperador.Text = "SegundoOperador";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(47, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // grpSistema
            // 
            this.grpSistema.AutoSize = true;
            this.grpSistema.Controls.Add(this.rdbDecimal);
            this.grpSistema.Controls.Add(this.rdbBinario);
            this.grpSistema.Location = new System.Drawing.Point(178, 114);
            this.grpSistema.Name = "grpSistema";
            this.grpSistema.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpSistema.Size = new System.Drawing.Size(200, 113);
            this.grpSistema.TabIndex = 8;
            this.grpSistema.TabStop = false;
            this.grpSistema.Text = "Representar resultado en:";
            this.grpSistema.UseWaitCursor = true;
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.Checked = true;
            this.rdbDecimal.Location = new System.Drawing.Point(20, 77);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.Size = new System.Drawing.Size(78, 17);
            this.rdbDecimal.TabIndex = 1;
            this.rdbDecimal.TabStop = true;
            this.rdbDecimal.Text = "rdbDecimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            this.rdbDecimal.UseWaitCursor = true;
            this.rdbDecimal.CheckedChanged += new System.EventHandler(this.rdbDecimal_CheckedChanged);
            // 
            // rdbBinario
            // 
            this.rdbBinario.AutoSize = true;
            this.rdbBinario.Location = new System.Drawing.Point(20, 38);
            this.rdbBinario.Name = "rdbBinario";
            this.rdbBinario.Size = new System.Drawing.Size(72, 17);
            this.rdbBinario.TabIndex = 0;
            this.rdbBinario.Text = "rdbBinario";
            this.rdbBinario.UseVisualStyleBackColor = true;
            this.rdbBinario.UseWaitCursor = true;
            this.rdbBinario.CheckedChanged += new System.EventHandler(this.rdbBinario_CheckedChanged);
            // 
            // txtSegundoOperando
            // 
            this.txtSegundoOperando.Location = new System.Drawing.Point(438, 252);
            this.txtSegundoOperando.Name = "txtSegundoOperando";
            this.txtSegundoOperando.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoOperando.TabIndex = 11;
            // 
            // txtPrimerOperando
            // 
            this.txtPrimerOperando.Location = new System.Drawing.Point(37, 252);
            this.txtPrimerOperando.Name = "txtPrimerOperando";
            this.txtPrimerOperando.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerOperando.TabIndex = 12;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.txtPrimerOperando);
            this.Controls.Add(this.txtSegundoOperando);
            this.Controls.Add(this.grpSistema);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSegundoOperador);
            this.Controls.Add(this.lblPrimerOperador);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbOperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.grpSistema.ResumeLayout(false);
            this.grpSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblPrimerOperador;
        private System.Windows.Forms.Label lblSegundoOperador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox grpSistema;
        private System.Windows.Forms.RadioButton rdbDecimal;
        private System.Windows.Forms.RadioButton rdbBinario;
        private System.Windows.Forms.TextBox txtSegundoOperando;
        private System.Windows.Forms.TextBox txtPrimerOperando;
    }
}