namespace AppNombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Grupo grupo = new Grupo();

        private void Form1_Load(object sender, EventArgs e)
        {
            grupo.NombreAgregado += Grupo_NombreAgregado;
        }

        private void Grupo_NombreAgregado(object? sender, EventArgs e)
        {
            lstNombres.DataSource = null;
            lstNombres.DataSource = grupo.Alumnos;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                grupo.Agregar(txtNombre.Text);
                txtNombre.Clear();
                txtNombre.Focus();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbExacto.Checked)
            {
                if (grupo.Existe(txtFiltro.Text))
                {
                    MessageBox.Show("Encontrado");
                }
                else
                {
                    MessageBox.Show("Encontrado");
                }
            }
            if (rdbEmpieza.Checked)
            {
                MessageBox.Show($"Concidencias: {grupo.ContarEmpieza(txtFiltro.Text)}");
            }
        }
    }
}