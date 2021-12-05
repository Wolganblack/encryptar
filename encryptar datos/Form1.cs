using encryptar_datos.encryptar_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace encryptar_datos
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PruebaEntities con = new PruebaEntities())
            {
                Encryptar probando = new Encryptar();
             
                probando.username = "Alfonso";
                probando.password = Clave.GetSHA256("123456");
                con.Encryptar.Add(probando);                
                con.SaveChanges();

            }
        }
    }
}
