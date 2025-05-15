namespace WinFormsArquivos
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
            textBox1 = new TextBox();
            bntAbrirArquivo = new Button();
            btnSalvarComo = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 353);
            textBox1.TabIndex = 0;
            // 
            // bntAbrirArquivo
            // 
            bntAbrirArquivo.Location = new Point(12, 12);
            bntAbrirArquivo.Name = "bntAbrirArquivo";
            bntAbrirArquivo.Size = new Size(169, 23);
            bntAbrirArquivo.TabIndex = 1;
            bntAbrirArquivo.Text = "Abrir Arquivo...\r\n\r\n\r\n";
            bntAbrirArquivo.UseVisualStyleBackColor = true;
            bntAbrirArquivo.Click += bntAbrirArquivo_Click;
            // 
            // btnSalvarComo
            // 
            btnSalvarComo.Location = new Point(187, 12);
            btnSalvarComo.Name = "btnSalvarComo";
            btnSalvarComo.Size = new Size(169, 23);
            btnSalvarComo.TabIndex = 1;
            btnSalvarComo.Text = "Salvar Como...";
            btnSalvarComo.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvarComo);
            Controls.Add(bntAbrirArquivo);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button bntAbrirArquivo;
        private Button btnSalvarComo;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
