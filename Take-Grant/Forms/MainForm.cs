﻿using System.Windows.Forms;
using TakeGrant.Model;
using TakeGrant.View;

namespace TakeGrant
{
    public partial class MainForm : Form
    {
        private AccessModel model;

        private GraphDrawer drawer;
        private AccessMatrixView matrix;
        private TakeGrantView takeGrant;

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
            this.matrix = new AccessMatrixView(accessMatrix);
            this.takeGrant = new TakeGrantView(
                takeGrantPictureBox,
                takeBtn,
                grantBtn,
                takeFromDropdown,
                GiveToDropdown,
                targetObjDropdown);

            matrix.Init(model);
            takeGrant.Init(model);
        }

        private void CreateMatrix(object sender, System.EventArgs e)
        {
            model.CreateMatrix((int)subjCount.Value, (int)objCount.Value);

            drawer.Init(model.Items);
            matrix.UpdateGrid();
            takeGrant.UpdateItems();

            graphPictureBox.Invalidate();
            accessMatrix.Invalidate();
        }

        private void ClearRights(object sender, System.EventArgs e)
        {
            model.ClearRights();

            graphPictureBox.Invalidate();
            matrix.UpdateGrid();
        }

        private void GenerateRights(object sender, System.EventArgs e)
        {
            model.RandomizeRights();

            graphPictureBox.Invalidate();
            matrix.UpdateGrid();
        }
    }
}
