namespace GestionUsuarios
{
    partial class Menu
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
            this.Gestionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gestionar
            // 
            this.Gestionar.Location = new System.Drawing.Point(156, 97);
            this.Gestionar.Name = "Gestionar";
            this.Gestionar.Size = new System.Drawing.Size(80, 58);
            this.Gestionar.TabIndex = 0;
            this.Gestionar.Text = "Gestion Clientes";
            this.Gestionar.UseVisualStyleBackColor = true;
            this.Gestionar.Click += new System.EventHandler(this.Gestionar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 273);
            this.Controls.Add(this.Gestionar);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gestionar;
    }
}

