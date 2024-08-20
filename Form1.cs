using System.Diagnostics.Eventing.Reader;

namespace PruebaWin_Form
{
    public partial class FormularioContacto : Form
    {
        public FormularioContacto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxNombre.Text) ||
         string.IsNullOrEmpty(TextBoxEmail.Text) ||
         string.IsNullOrEmpty(TextBoxMensaje.Text))
            {
                LabelEstado.Text = "Debe completar todos los campos.";
            }
            else
            {
                LabelEstado.Text = "El Formulario ha sido enviado.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
