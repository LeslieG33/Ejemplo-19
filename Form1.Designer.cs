namespace Ejemplo_19
{
    partial class frmEjemplo19
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
            this.cmdOrdenamiento = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.txtOrdenado = new System.Windows.Forms.TextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdOrdenamiento
            // 
            this.cmdOrdenamiento.Location = new System.Drawing.Point(34, 31);
            this.cmdOrdenamiento.Name = "cmdOrdenamiento";
            this.cmdOrdenamiento.Size = new System.Drawing.Size(245, 23);
            this.cmdOrdenamiento.TabIndex = 0;
            this.cmdOrdenamiento.Text = "&Ordenamiento de números";
            this.cmdOrdenamiento.UseVisualStyleBackColor = true;
            this.cmdOrdenamiento.Click += new System.EventHandler(this.cmdOrdenamiento_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(31, 73);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(42, 13);
            this.lblOriginal.TabIndex = 1;
            this.lblOriginal.Text = "Original";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(34, 89);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.Size = new System.Drawing.Size(100, 202);
            this.txtOriginal.TabIndex = 2;
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(176, 73);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(54, 13);
            this.lblOrdenado.TabIndex = 3;
            this.lblOrdenado.Text = "Ordenado";
            // 
            // txtOrdenado
            // 
            this.txtOrdenado.Location = new System.Drawing.Point(179, 89);
            this.txtOrdenado.Multiline = true;
            this.txtOrdenado.Name = "txtOrdenado";
            this.txtOrdenado.ReadOnly = true;
            this.txtOrdenado.Size = new System.Drawing.Size(100, 202);
            this.txtOrdenado.TabIndex = 4;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(312, 91);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 5;
            this.cmdLimpiar.Text = "&Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSalir.Location = new System.Drawing.Point(312, 129);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmEjemplo19
            // 
            this.AcceptButton = this.cmdOrdenamiento;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdSalir;
            this.ClientSize = new System.Drawing.Size(406, 329);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtOrdenado);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.cmdOrdenamiento);
            this.Name = "frmEjemplo19";
            this.Text = "Orden ascendente de números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOrdenamiento;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.TextBox txtOrdenado;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSalir;
    }
}

