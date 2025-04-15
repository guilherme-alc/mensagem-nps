using MensagensNPS.Models;

namespace MensagensNPS
{
    public partial class FormCadastroTemplate : Form
    {
        public FormCadastroTemplate()
        {
            InitializeComponent();
        }

        public Template NovoTemplate;

        private void Cadastrar(object sender, EventArgs e)
        {
            NovoTemplate = new Template(txtNomeTemplate.Text, txtConteudoTemplate.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
