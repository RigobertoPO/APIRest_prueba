
namespace APIPRUEBA.ClienteWindows
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
            this.ApiExternabutton = new System.Windows.Forms.Button();
            this.ResultadodataGridView = new System.Windows.Forms.DataGridView();
            this.ApiLocalbutton = new System.Windows.Forms.Button();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TitulotextBox = new System.Windows.Forms.TextBox();
            this.EditorialtextBox = new System.Windows.Forms.TextBox();
            this.AñotextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApiExternabutton
            // 
            this.ApiExternabutton.Location = new System.Drawing.Point(12, 22);
            this.ApiExternabutton.Name = "ApiExternabutton";
            this.ApiExternabutton.Size = new System.Drawing.Size(151, 23);
            this.ApiExternabutton.TabIndex = 0;
            this.ApiExternabutton.Text = "Consultar API externa";
            this.ApiExternabutton.UseVisualStyleBackColor = true;
            this.ApiExternabutton.Click += new System.EventHandler(this.ApiExternabutton_Click);
            // 
            // ResultadodataGridView
            // 
            this.ResultadodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadodataGridView.Location = new System.Drawing.Point(12, 66);
            this.ResultadodataGridView.Name = "ResultadodataGridView";
            this.ResultadodataGridView.Size = new System.Drawing.Size(586, 186);
            this.ResultadodataGridView.TabIndex = 1;
            // 
            // ApiLocalbutton
            // 
            this.ApiLocalbutton.Location = new System.Drawing.Point(187, 22);
            this.ApiLocalbutton.Name = "ApiLocalbutton";
            this.ApiLocalbutton.Size = new System.Drawing.Size(177, 23);
            this.ApiLocalbutton.TabIndex = 2;
            this.ApiLocalbutton.Text = "Consultar API local";
            this.ApiLocalbutton.UseVisualStyleBackColor = true;
            this.ApiLocalbutton.Click += new System.EventHandler(this.ApiLocalbutton_Click);
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(630, 86);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(185, 20);
            this.ISBNtextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // TitulotextBox
            // 
            this.TitulotextBox.Location = new System.Drawing.Point(633, 130);
            this.TitulotextBox.Name = "TitulotextBox";
            this.TitulotextBox.Size = new System.Drawing.Size(182, 20);
            this.TitulotextBox.TabIndex = 8;
            // 
            // EditorialtextBox
            // 
            this.EditorialtextBox.Location = new System.Drawing.Point(633, 169);
            this.EditorialtextBox.Name = "EditorialtextBox";
            this.EditorialtextBox.Size = new System.Drawing.Size(179, 20);
            this.EditorialtextBox.TabIndex = 9;
            // 
            // AñotextBox
            // 
            this.AñotextBox.Location = new System.Drawing.Point(633, 211);
            this.AñotextBox.Name = "AñotextBox";
            this.AñotextBox.Size = new System.Drawing.Size(182, 20);
            this.AñotextBox.TabIndex = 10;
            this.AñotextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(633, 250);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(124, 23);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar Libro";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 297);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.AñotextBox);
            this.Controls.Add(this.EditorialtextBox);
            this.Controls.Add(this.TitulotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.ApiLocalbutton);
            this.Controls.Add(this.ResultadodataGridView);
            this.Controls.Add(this.ApiExternabutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApiExternabutton;
        private System.Windows.Forms.DataGridView ResultadodataGridView;
        private System.Windows.Forms.Button ApiLocalbutton;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TitulotextBox;
        private System.Windows.Forms.TextBox EditorialtextBox;
        private System.Windows.Forms.TextBox AñotextBox;
        private System.Windows.Forms.Button Guardarbutton;
    }
}

