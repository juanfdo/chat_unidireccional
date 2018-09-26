namespace ejemplo_de_cliente
{
    partial class ejemplo_de_cliente
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
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.btEnvia = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMensaje
            // 
            this.tbMensaje.Location = new System.Drawing.Point(12, 60);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(206, 20);
            this.tbMensaje.TabIndex = 0;
            // 
            // btEnvia
            // 
            this.btEnvia.Location = new System.Drawing.Point(224, 60);
            this.btEnvia.Name = "btEnvia";
            this.btEnvia.Size = new System.Drawing.Size(75, 23);
            this.btEnvia.TabIndex = 1;
            this.btEnvia.Text = "Envía";
            this.btEnvia.UseVisualStyleBackColor = true;
            this.btEnvia.Click += new System.EventHandler(this.btEnvia_Click);
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(12, 12);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 2;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // ejemplo_de_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 116);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.btEnvia);
            this.Controls.Add(this.tbMensaje);
            this.Name = "ejemplo_de_cliente";
            this.Text = "Ejemplo de cliente";
            this.Load += new System.EventHandler(this.ejemplo_de_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMensaje;
        private System.Windows.Forms.Button btEnvia;
        private System.Windows.Forms.Button btConectar;
    }
}

