namespace AppRadix_Sort
{
    partial class Form1
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
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LtbOrdenada = new System.Windows.Forms.ListBox();
            this.LtbDesordenada = new System.Windows.Forms.ListBox();
            this.BtnVaciar = new System.Windows.Forms.Button();
            this.LblOrdenada = new System.Windows.Forms.Label();
            this.LblDesOrdenada = new System.Windows.Forms.Label();
            this.LblTamaño = new System.Windows.Forms.Label();
            this.LtbTiempo = new System.Windows.Forms.ListBox();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Location = new System.Drawing.Point(12, 25);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(211, 20);
            this.TxtTamaño.TabIndex = 0;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(377, 9);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(79, 47);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LtbOrdenada
            // 
            this.LtbOrdenada.FormattingEnabled = true;
            this.LtbOrdenada.Location = new System.Drawing.Point(298, 104);
            this.LtbOrdenada.Name = "LtbOrdenada";
            this.LtbOrdenada.Size = new System.Drawing.Size(210, 251);
            this.LtbOrdenada.TabIndex = 2;
            // 
            // LtbDesordenada
            // 
            this.LtbDesordenada.FormattingEnabled = true;
            this.LtbDesordenada.Location = new System.Drawing.Point(22, 104);
            this.LtbDesordenada.Name = "LtbDesordenada";
            this.LtbDesordenada.Size = new System.Drawing.Size(210, 251);
            this.LtbDesordenada.TabIndex = 3;
            // 
            // BtnVaciar
            // 
            this.BtnVaciar.Location = new System.Drawing.Point(283, 9);
            this.BtnVaciar.Name = "BtnVaciar";
            this.BtnVaciar.Size = new System.Drawing.Size(79, 44);
            this.BtnVaciar.TabIndex = 4;
            this.BtnVaciar.Text = "Vaciar";
            this.BtnVaciar.UseVisualStyleBackColor = true;
            this.BtnVaciar.Click += new System.EventHandler(this.BtnVaciar_Click);
            // 
            // LblOrdenada
            // 
            this.LblOrdenada.AutoSize = true;
            this.LblOrdenada.Location = new System.Drawing.Point(305, 88);
            this.LblOrdenada.Name = "LblOrdenada";
            this.LblOrdenada.Size = new System.Drawing.Size(57, 13);
            this.LblOrdenada.TabIndex = 5;
            this.LblOrdenada.Text = "Ordenada:";
            // 
            // LblDesOrdenada
            // 
            this.LblDesOrdenada.AutoSize = true;
            this.LblDesOrdenada.Location = new System.Drawing.Point(19, 88);
            this.LblDesOrdenada.Name = "LblDesOrdenada";
            this.LblDesOrdenada.Size = new System.Drawing.Size(79, 13);
            this.LblDesOrdenada.TabIndex = 6;
            this.LblDesOrdenada.Text = "Des-Ordenada:";
            // 
            // LblTamaño
            // 
            this.LblTamaño.AutoSize = true;
            this.LblTamaño.Location = new System.Drawing.Point(69, 9);
            this.LblTamaño.Name = "LblTamaño";
            this.LblTamaño.Size = new System.Drawing.Size(49, 13);
            this.LblTamaño.TabIndex = 7;
            this.LblTamaño.Text = "Tamaño:";
            // 
            // LtbTiempo
            // 
            this.LtbTiempo.FormattingEnabled = true;
            this.LtbTiempo.Location = new System.Drawing.Point(462, 26);
            this.LtbTiempo.Name = "LtbTiempo";
            this.LtbTiempo.Size = new System.Drawing.Size(171, 30);
            this.LtbTiempo.TabIndex = 8;
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Location = new System.Drawing.Point(462, 9);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(45, 13);
            this.LblTiempo.TabIndex = 9;
            this.LblTiempo.Text = "Tiempo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 438);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.LtbTiempo);
            this.Controls.Add(this.LblTamaño);
            this.Controls.Add(this.LblDesOrdenada);
            this.Controls.Add(this.LblOrdenada);
            this.Controls.Add(this.BtnVaciar);
            this.Controls.Add(this.LtbDesordenada);
            this.Controls.Add(this.LtbOrdenada);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtTamaño);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTamaño;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.ListBox LtbOrdenada;
        private System.Windows.Forms.ListBox LtbDesordenada;
        private System.Windows.Forms.Button BtnVaciar;
        private System.Windows.Forms.Label LblOrdenada;
        private System.Windows.Forms.Label LblDesOrdenada;
        private System.Windows.Forms.Label LblTamaño;
        private System.Windows.Forms.ListBox LtbTiempo;
        private System.Windows.Forms.Label LblTiempo;
    }
}

