namespace Halftoning
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
            this.ImgOriginal = new System.Windows.Forms.PictureBox();
            this.ImgFinal = new System.Windows.Forms.PictureBox();
            this.Tec1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.abrirImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFinal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgOriginal
            // 
            this.ImgOriginal.Location = new System.Drawing.Point(12, 12);
            this.ImgOriginal.Name = "ImgOriginal";
            this.ImgOriginal.Size = new System.Drawing.Size(438, 408);
            this.ImgOriginal.TabIndex = 0;
            this.ImgOriginal.TabStop = false;
            // 
            // ImgFinal
            // 
            this.ImgFinal.Location = new System.Drawing.Point(456, 12);
            this.ImgFinal.Name = "ImgFinal";
            this.ImgFinal.Size = new System.Drawing.Size(428, 408);
            this.ImgFinal.TabIndex = 1;
            this.ImgFinal.TabStop = false;
            // 
            // Tec1
            // 
            this.Tec1.Location = new System.Drawing.Point(13, 444);
            this.Tec1.Name = "Tec1";
            this.Tec1.Size = new System.Drawing.Size(131, 23);
            this.Tec1.TabIndex = 2;
            this.Tec1.Text = "Ordered dithering ";
            this.Tec1.UseVisualStyleBackColor = true;
            this.Tec1.Click += new System.EventHandler(this.Tec1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Floyde e Stenberg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sierra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Burkes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Jarvis, Judice e Ninke";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 482);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Stucki";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(419, 444);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Bayer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(419, 482);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Difusão de Erro";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Escolha a Técnica:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.abrirImagem);
            this.groupBox1.Location = new System.Drawing.Point(675, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações Comuns";
            // 
            // abrirImagem
            // 
            this.abrirImagem.Location = new System.Drawing.Point(58, 40);
            this.abrirImagem.Name = "abrirImagem";
            this.abrirImagem.Size = new System.Drawing.Size(98, 23);
            this.abrirImagem.TabIndex = 0;
            this.abrirImagem.Text = "Abrir Imagem";
            this.abrirImagem.UseVisualStyleBackColor = true;
            this.abrirImagem.Click += new System.EventHandler(this.abrirImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tec1);
            this.Controls.Add(this.ImgFinal);
            this.Controls.Add(this.ImgOriginal);
            this.Name = "Form1";
            this.Text = "Técnicas HalfToning";
            ((System.ComponentModel.ISupportInitialize)(this.ImgOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFinal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgOriginal;
        private System.Windows.Forms.PictureBox ImgFinal;
        private System.Windows.Forms.Button Tec1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button abrirImagem;
    }
}

