namespace NovaOpcao
{
    partial class GerenciaEMAIL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PARA = new System.Windows.Forms.TextBox();
            this.COPIA = new System.Windows.Forms.TextBox();
            this.Assunto = new System.Windows.Forms.TextBox();
            this.corpo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DE = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assunto:";
            // 
            // PARA
            // 
            this.PARA.Location = new System.Drawing.Point(71, 31);
            this.PARA.Name = "PARA";
            this.PARA.Size = new System.Drawing.Size(704, 20);
            this.PARA.TabIndex = 3;
            // 
            // COPIA
            // 
            this.COPIA.Location = new System.Drawing.Point(71, 54);
            this.COPIA.Name = "COPIA";
            this.COPIA.Size = new System.Drawing.Size(704, 20);
            this.COPIA.TabIndex = 4;
            // 
            // Assunto
            // 
            this.Assunto.Location = new System.Drawing.Point(71, 80);
            this.Assunto.Name = "Assunto";
            this.Assunto.Size = new System.Drawing.Size(704, 20);
            this.Assunto.TabIndex = 5;
            // 
            // corpo
            // 
            this.corpo.Location = new System.Drawing.Point(71, 127);
            this.corpo.Name = "corpo";
            this.corpo.Size = new System.Drawing.Size(704, 234);
            this.corpo.TabIndex = 6;
            this.corpo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "De:";
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(71, 6);
            this.DE.Name = "DE";
            this.DE.ReadOnly = true;
            this.DE.Size = new System.Drawing.Size(704, 20);
            this.DE.TabIndex = 9;
            this.DE.Text = "novaopcao@globo.com";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(781, 6);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(87, 95);
            this.send.TabIndex = 10;
            this.send.Text = "Enviar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // GerenciaEMAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 421);
            this.Controls.Add(this.send);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.corpo);
            this.Controls.Add(this.Assunto);
            this.Controls.Add(this.COPIA);
            this.Controls.Add(this.PARA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GerenciaEMAIL";
            this.Text = "GerenciaEMAIL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PARA;
        private System.Windows.Forms.TextBox COPIA;
        private System.Windows.Forms.TextBox Assunto;
        private System.Windows.Forms.RichTextBox corpo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DE;
        private System.Windows.Forms.Button send;
    }
}