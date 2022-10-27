using Funcionalidad.clases;

namespace Grafica
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(textBox1.Text, textBox2.Text);

            if (user.ComprobarInicio())
            {
                frm_MenuPrincipal principal = new frm_MenuPrincipal();
                this.Hide();
                if(principal.ShowDialog()== DialogResult.Cancel)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    this.Show();
                }
            }
        }
    }
}