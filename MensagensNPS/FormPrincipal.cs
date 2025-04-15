namespace MensagensNPS
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public string TemplateCadastrado { get; set; }

        private void CadastrarTemplate(object sender, EventArgs e)
        {

            using (var modalCadastro = new FormCadastroTemplate())
            {
                modalCadastro.FormBorderStyle = FormBorderStyle.FixedDialog;
                modalCadastro.StartPosition = FormStartPosition.CenterParent;


                var resultado = modalCadastro.ShowDialog(this);
                if (resultado == DialogResult.OK)
                {
                    TemplateCadastrado = modalCadastro.Template;
                }
            }
        }

        private void SairAplicação(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
