//using System.IO;


namespace ExpresionesNodos
{
    public partial class MainForm : Form
    {
        private Nodo raiz;
        private Arbol arbol;
        Grafico grafico;

        public MainForm()
        {
            InitializeComponent();
            arbol = new Arbol();

        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if(txtExpresion.Text != "")
            {
                arbol.InsertarEnCola(txtExpresion.Text);
                raiz = arbol.CrearArbol();
                arbol.Limpiar();
                lblPre.Text = arbol.InsertaPre(raiz);
                lblIn.Text = arbol.InsertaIn(raiz);
                lblPost.Text = arbol.InsertaPost(raiz);
                grafico = new Grafico(arbol.nodoDot);
                grafico.DrawTree();
                ShowTree();
            }
            else
            {
                MessageBox.Show("Debes ingresar una expresion valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTree()
        {
            if (File.Exists(@"C:\Users\calel\Imagen.png"))
            {
                using (FileStream img = new FileStream(@"C:\Users\calel\Imagen.png", FileMode.Open, FileAccess.Read))
                {
                    pbImagen.Image = Bitmap.FromStream(img);
                }
            }
            else
            {
                MessageBox.Show("no se a podido abrir el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pbImagen.Refresh();
        }

    }
}