using System.Windows.Forms;
using TakeGrant.Model;
using TakeGrant.View;

namespace TakeGrant
{
    public partial class MainForm : Form
    {
        private AccessModel model;

        private GraphDrawer drawer;
        private EditItemPanel editItemView;


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
            this.editItemView = new EditItemPanel(
                subjEditChooseDropdown,
                subjEditName,
                subjEditSaveBtn,
                subjEditRemoveBtn);

            editItemView.Init(model);
        }
    }
}
