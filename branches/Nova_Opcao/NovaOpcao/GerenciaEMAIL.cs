using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using System.Net.Mail;

namespace NovaOpcao
{
    public partial class GerenciaEMAIL : Form
    {
        
        public GerenciaEMAIL()
        {
            InitializeComponent();
        }




        private void send_Click(object sender, EventArgs e)
        {

            string[] args = new string[200];

            SmtpClient smtp = new SmtpClient(args[0]);
            smtp.Host = "BRSPX002.samerica.br.int.atosorigin.com";
  
            MailAddress remetente = new MailAddress(DE.ToString(), "Nova Opção Locações");

            MailAddress para = new MailAddress(PARA.ToString(), PARA.ToString());
            MailMessage mensagem = new MailMessage(remetente, para);
            string userState = "test message1";
            mensagem.Body = "Este é apenas um teste de envio de e-mail";
            mensagem.BodyEncoding = System.Text.Encoding.UTF8;
            mensagem.SubjectEncoding = System.Text.Encoding.UTF8;
            mensagem.Subject = "Teste de Envio";
            smtp.SendAsync(mensagem, userState);
            
        }

       


        
    }
}
