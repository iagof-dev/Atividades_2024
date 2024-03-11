namespace TesteQualidSoma
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
            txt_n1 = new TextBox();
            txt_n2 = new TextBox();
            btnSomar = new Button();
            btn_Limpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Resultado = new TextBox();
            SuspendLayout();
            // 
            // txt_n1
            // 
            txt_n1.Location = new Point(63, 37);
            txt_n1.Name = "txt_n1";
            txt_n1.Size = new Size(204, 23);
            txt_n1.TabIndex = 0;
            // 
            // txt_n2
            // 
            txt_n2.Location = new Point(63, 94);
            txt_n2.Name = "txt_n2";
            txt_n2.Size = new Size(204, 23);
            txt_n2.TabIndex = 1;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(46, 135);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(127, 31);
            btnSomar.TabIndex = 2;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(179, 135);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(127, 31);
            btn_Limpar.TabIndex = 3;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "1° Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 77);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "2° Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 170);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Resultado:";
            // 
            // txt_Resultado
            // 
            txt_Resultado.Location = new Point(63, 187);
            txt_Resultado.Name = "txt_Resultado";
            txt_Resultado.Size = new Size(204, 23);
            txt_Resultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 218);
            Controls.Add(label3);
            Controls.Add(txt_Resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Limpar);
            Controls.Add(btnSomar);
            Controls.Add(txt_n2);
            Controls.Add(txt_n1);
            Name = "Form1";
            Text = "Faça soma de 2 números.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_n1;
        private TextBox txt_n2;
        private Button btnSomar;
        private Button btn_Limpar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Resultado;
    }
}
