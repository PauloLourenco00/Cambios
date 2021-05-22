
namespace Cambios
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonTroca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(127, 75);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(344, 27);
            this.textBoxValor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de destino:";
            // 
            // comboBoxOrigem
            // 
            this.comboBoxOrigem.FormattingEnabled = true;
            this.comboBoxOrigem.Location = new System.Drawing.Point(227, 129);
            this.comboBoxOrigem.Name = "comboBoxOrigem";
            this.comboBoxOrigem.Size = new System.Drawing.Size(244, 28);
            this.comboBoxOrigem.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(227, 192);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(244, 28);
            this.comboBoxDestino.TabIndex = 5;
            // 
            // buttonConverter
            // 
            this.buttonConverter.Enabled = false;
            this.buttonConverter.Location = new System.Drawing.Point(527, 73);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(133, 54);
            this.buttonConverter.TabIndex = 6;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(227, 275);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(313, 20);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(66, 365);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 20);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(448, 385);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 29);
            this.progressBar1.TabIndex = 9;
            // 
            // buttonTroca
            // 
            this.buttonTroca.Enabled = false;
            this.buttonTroca.Location = new System.Drawing.Point(527, 166);
            this.buttonTroca.Name = "buttonTroca";
            this.buttonTroca.Size = new System.Drawing.Size(133, 54);
            this.buttonTroca.TabIndex = 10;
            this.buttonTroca.UseVisualStyleBackColor = true;
            this.buttonTroca.Click += new System.EventHandler(this.buttonTroca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.buttonTroca);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cambios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrigem;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonTroca;
    }
}

