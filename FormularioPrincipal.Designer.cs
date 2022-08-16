namespace WindowsFormsApp1
{
    partial class FormularioPrincipal
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
            this.btnAbrirCarpeta = new System.Windows.Forms.Button();
            this.lboxListaArchivos = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCodigoCompleto = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.Location = new System.Drawing.Point(499, 94);
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirCarpeta.TabIndex = 0;
            this.btnAbrirCarpeta.Text = "AbrirCarpeta";
            this.btnAbrirCarpeta.UseVisualStyleBackColor = true;
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // lboxListaArchivos
            // 
            this.lboxListaArchivos.FormattingEnabled = true;
            this.lboxListaArchivos.Location = new System.Drawing.Point(2, 52);
            this.lboxListaArchivos.Name = "lboxListaArchivos";
            this.lboxListaArchivos.Size = new System.Drawing.Size(491, 212);
            this.lboxListaArchivos.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo C#|*.cs|Archivos de texto|*.txt";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblCodigoCompleto
            // 
            this.lblCodigoCompleto.AutoSize = true;
            this.lblCodigoCompleto.Location = new System.Drawing.Point(338, 330);
            this.lblCodigoCompleto.Name = "lblCodigoCompleto";
            this.lblCodigoCompleto.Size = new System.Drawing.Size(94, 13);
            this.lblCodigoCompleto.TabIndex = 2;
            this.lblCodigoCompleto.Text = "lblCodigoCompleto";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(499, 187);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Codigo";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(614, 94);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(538, 52);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 16);
            this.lblInformacion.TabIndex = 5;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblCodigoCompleto);
            this.Controls.Add(this.lboxListaArchivos);
            this.Controls.Add(this.btnAbrirCarpeta);
            this.Name = "FormularioPrincipal";
            this.Text = "Generador de Scripts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCarpeta;
        private System.Windows.Forms.ListBox lboxListaArchivos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCodigoCompleto;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblInformacion;
    }
}

