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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private Form ActiveForm = null;
        private void abrirEnPanel(Form child)
        {
            if(ActiveForm != null)
                ActiveForm.Close();
                ActiveForm = child;
                child.TopLevel = false;
                child.FormBorderStyle = FormBorderStyle.None;
                child.Dock = DockStyle.Fill;
                PanelPrincipal.Controls.Add(child);
                PanelPrincipal.Tag = child;
                child.BringToFront();
                child.Show();
            
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.Bounds.Location; 
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actaulizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            abrirEnPanel(new RegistrodeEmpleado());
           // RegistrodeEmpleado empleado = new RegistrodeEmpleado();
           // empleado.Show();
        }


    }
    
}
