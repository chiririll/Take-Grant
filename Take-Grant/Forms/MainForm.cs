using System.Windows.Forms;
using TakeGrant.Model;

namespace TakeGrant
{
    public partial class MainForm : Form
    {
        private readonly GraphDrawer drawer;

        private AccessModel model;

        public MainForm()
        {
            InitializeComponent();

            model = new AccessModel();
        }

        public void DrawGraph()
        {

        }
    }
}
