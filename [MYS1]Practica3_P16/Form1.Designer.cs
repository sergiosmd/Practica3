namespace _MYS1_Practica3_P16
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabGrupo = new System.Windows.Forms.Label();
            this.labCarnets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Modelo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cargar Archivo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LabGrupo
            // 
            this.LabGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGrupo.Location = new System.Drawing.Point(1, 28);
            this.LabGrupo.Name = "LabGrupo";
            this.LabGrupo.Size = new System.Drawing.Size(377, 44);
            this.LabGrupo.TabIndex = 2;
            this.LabGrupo.Text = "Pareja No. 16";
            this.LabGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCarnets
            // 
            this.labCarnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCarnets.Location = new System.Drawing.Point(40, 72);
            this.labCarnets.Name = "labCarnets";
            this.labCarnets.Size = new System.Drawing.Size(105, 54);
            this.labCarnets.TabIndex = 3;
            this.labCarnets.Text = "200715274\r\n200915305\r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelación y Simulación 1\r\n2do. Semestre\r\n2020\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labCarnets);
            this.Controls.Add(this.LabGrupo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Practica 3 - Modelación y Simulación 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabGrupo;
        private System.Windows.Forms.Label labCarnets;
        private System.Windows.Forms.Label label1;
    }
}

