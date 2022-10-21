using Funcionalidad;

namespace Grafica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(textBox1.Text, textBox2.Text);

            if (user.ComprobarInicio())
            {
                frmMenuPrincipal principal = new frmMenuPrincipal();
                if(principal.ShowDialog()== DialogResult.Cancel)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }
    }
}