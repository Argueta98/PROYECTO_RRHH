using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH
{
    public partial class inicio : Form
    {
        private Timer ti;
        ENTIDAD.login_E obje = new ENTIDAD.login_E();
        NEGOCIO.login_N objd = new NEGOCIO.login_N();

        public inicio()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
           
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lbltime.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lbltime_Click(object sender, EventArgs e)  

        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {
           
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            inicio.ActiveForm.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.usuario = txtusuario.Text;
            obje.pass = txtcontrasenia.Text;
            dt = objd.login_N1(obje);

            if(dt.Rows.Count > 0)
            {
                obje.usuario = dt.Rows[0][3].ToString();
                obje.pass = dt.Rows[0][1].ToString();
                MessageBox.Show("Bienvenido " + obje.usuario);
                this.Hide();

                dashboard dashboard = new dashboard();
                dashboard.Show();
                
                
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");
                txtcontrasenia.Text = String.Empty;
                txtusuario.Text = String.Empty;
            }

        }
    }
}
