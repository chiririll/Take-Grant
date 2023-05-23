using System.Windows.Forms;
using TakeGrant.Model;

namespace TakeGrant
{
    public partial class MainForm : Form
    {
        private GraphDrawer drawer;

        private AccessModel model;

        public MainForm()
        {
            InitializeComponent();

            model = new AccessModel();
        }

        private void DrawGraph(object sender, System.EventArgs e)
        {
            drawer.Init(model.Items);
        }

        private void Initialize(object sender, System.EventArgs e)
        {
            this.drawer = new GraphDrawer(graphPictureBox, graphLabel);
        }
    }
}
