namespace ejemplo_de_servidor
{
    partial class ejemplo_de_servidor
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
            this.rtbMensajes = new System.Windows.Forms.RichTextBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btTerminar = new System.Windows.Forms.Button();
            this.btLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMensajes
            // 
            this.rtbMensajes.Location = new System.Drawing.Point(12, 38);
            this.rtbMensajes.Name = "rtbMensajes";
            this.rtbMensajes.Size = new System.Drawing.Size(363, 329);
            this.rtbMensajes.TabIndex = 0;
            this.rtbMensajes.Text = "";
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(382, 38);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(79, 23);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btTerminar
            // 
            this.btTerminar.Location = new System.Drawing.Point(382, 68);
            this.btTerminar.Name = "btTerminar";
            this.btTerminar.Size = new System.Drawing.Size(79, 23);
            this.btTerminar.TabIndex = 2;
            this.btTerminar.Text = "Terminar";
            this.btTerminar.UseVisualStyleBackColor = true;
            this.btTerminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(381, 130);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(80, 23);
            this.btLeer.TabIndex = 3;
            this.btLeer.Text = "Leer Mensaje";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // ejemplo_de_servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.btLeer);
            this.Controls.Add(this.btTerminar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.rtbMensajes);
            this.Name = "ejemplo_de_servidor";
            this.Text = "Ejemplo de servidor";
            this.Load += new System.EventHandler(this.ejemplo_de_servidor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMensajes;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btTerminar;
        private System.Windows.Forms.Button btLeer;
    }
}

