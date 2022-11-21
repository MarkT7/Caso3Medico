namespace Caso3Medico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMedicoToString = new System.Windows.Forms.Button();
            this.btnPacienteToString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(314, 141);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(158, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Medico y Paciente";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMedicoToString
            // 
            this.btnMedicoToString.Location = new System.Drawing.Point(228, 214);
            this.btnMedicoToString.Name = "btnMedicoToString";
            this.btnMedicoToString.Size = new System.Drawing.Size(124, 23);
            this.btnMedicoToString.TabIndex = 1;
            this.btnMedicoToString.Text = "Medico.ToString()";
            this.btnMedicoToString.UseVisualStyleBackColor = true;
            this.btnMedicoToString.Click += new System.EventHandler(this.btnMedicoToString_Click);
            // 
            // btnPacienteToString
            // 
            this.btnPacienteToString.Location = new System.Drawing.Point(443, 214);
            this.btnPacienteToString.Name = "btnPacienteToString";
            this.btnPacienteToString.Size = new System.Drawing.Size(136, 23);
            this.btnPacienteToString.TabIndex = 2;
            this.btnPacienteToString.Text = "Paciente.ToString";
            this.btnPacienteToString.UseVisualStyleBackColor = true;
            this.btnPacienteToString.Click += new System.EventHandler(this.btnPacienteToString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPacienteToString);
            this.Controls.Add(this.btnMedicoToString);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCrear;
        private Button btnMedicoToString;
        private Button btnPacienteToString;
    }
}