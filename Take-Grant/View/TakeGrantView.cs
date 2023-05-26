using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TakeGrant.Model;

namespace TakeGrant.View
{
    public class TakeGrantView
    {
        private const string permissionDenied = "Нет прав";

        private readonly PictureBox canvas;

        private readonly Button takeButton;
        private readonly Button grantButton;

        private readonly ComboBox itemSSelector;
        private readonly ComboBox itemXSelector;
        private readonly ComboBox itemYSelector;

        private AccessModel model;

        private Pen solidPen;
        private Pen dashedPen;

        private GraphType currentType;

        public TakeGrantView(
            PictureBox canvas,
            Button takeButton,
            Button grantButton,
            ComboBox itemSSelector,
            ComboBox ItemXSelector,
            ComboBox ItemYSelector)
        {
            this.canvas = canvas;

            this.takeButton = takeButton;
            this.grantButton = grantButton;

            this.itemSSelector = itemSSelector;
            this.itemXSelector = ItemXSelector;
            this.itemYSelector = ItemYSelector;

            canvas.Paint += Draw;

            takeButton.Click += Take;
            grantButton.Click += Grant;

            solidPen = new Pen(Color.Black);
            dashedPen = new Pen(Color.Black);
            
            dashedPen.DashPattern = new float[] { 5, 5 };
            
            var capPath = new GraphicsPath();
            capPath.AddLine(-0, 0, -5, -5);
            capPath.AddLine(0, 0, 5, -5);
            
            var cap = new CustomLineCap(null, capPath);
            solidPen.CustomEndCap = cap;
            dashedPen.CustomEndCap = cap; 
        }

        ~TakeGrantView()
        {
            canvas.Paint -= Draw;

            takeButton.Click -= Take;
            grantButton.Click -= Grant;
        }

        private Item itemS;
        private Item itemX;
        private Item itemY;

        public void Init(AccessModel model)
        {
            this.model = model;

            currentType = GraphType.None;
            UpdateItems();
        }

        public void UpdateItems()
        {
            itemSSelector.Items.Clear();
            itemXSelector.Items.Clear();
            itemYSelector.Items.Clear();

            foreach (var item in model.Subjects)
            {
                itemSSelector.Items.Add(item);
                itemXSelector.Items.Add(item);
            }

            foreach (var item in model.Objects)
            {
                itemYSelector.Items.Add(item);
            }
        }

        public void Take(object sender, EventArgs e)
        {
            UpdateSelectedItems();
            if (!CheckItems())
                return;

            if (!itemS.AccessRights.TryGetValue(itemX.Id, out var rightsSX) || (rightsSX & Rights.Type.Take) == 0)
            {
                MessageBox.Show(permissionDenied);
                return;
            }

            if (!itemX.AccessRights.TryGetValue(itemY.Id, out var rightsXY) || rightsXY == Rights.Type.None)
            {
                MessageBox.Show(permissionDenied);
                return;
            }

            currentType = GraphType.Take;

            canvas.Invalidate();
        }

        public void Grant(object sender, EventArgs e)
        {
            UpdateSelectedItems();
            if (!CheckItems())
                return;

            if (!itemS.AccessRights.TryGetValue(itemX.Id, out var rightsSX) || (rightsSX & Rights.Type.Grant) == 0)
            {
                MessageBox.Show(permissionDenied);
                return;
            }

            if (!itemS.AccessRights.TryGetValue(itemY.Id, out var rightsSY) || rightsSY == Rights.Type.None)
            {
                MessageBox.Show(permissionDenied);
                return;
            }

            currentType = GraphType.Grant;

            canvas.Invalidate();
        }

        private void UpdateSelectedItems()
        {
            currentType = GraphType.None;
            itemS = itemSSelector.SelectedItem as Item;
            itemX = itemXSelector.SelectedItem as Item;
            itemY = itemYSelector.SelectedItem as Item;
        }

        private bool CheckItems()
        {
            return itemS != null || itemX != null || itemY != null;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            if (!CheckItems())
                return;

            var y = canvas.Size.Height / 2;
            var dx = canvas.Size.Width / 4;

            var sView = new ItemView(dx * 1, y, itemS);
            var xView = new ItemView(dx * 2, y, itemX);
            var yView = new ItemView(dx * 3, y, itemY);

            if (currentType == GraphType.Take)
                DrawTakeRights(e.Graphics, sView, xView, yView);
            else if (currentType == GraphType.Grant)
                DrawGrantRights(e.Graphics, sView, xView, yView);

            sView.Draw(e.Graphics);
            xView.Draw(e.Graphics);
            yView.Draw(e.Graphics);

        }

        private void DrawTakeRights(Graphics g, ItemView sView, ItemView xView, ItemView yView)
        {
            DrawRight(g, sView, xView);
            DrawRight(g, xView, yView);
            DrawRight(g, sView, yView, true, true, xView.Rights[yView.Id]);
        }

        private void DrawGrantRights(Graphics g, ItemView sView, ItemView xView, ItemView yView)
        {
            DrawRight(g, sView, xView);
            DrawRight(g, sView, yView, false, true);
            DrawRight(g, xView, yView, true, false, sView.Rights[yView.Id]);
        }

        private void DrawRight(
            Graphics g,
            ItemView src,
            ItemView dst,
            bool dashed = false,
            bool curved = false,
            Rights.Type rights = Rights.Type.None)
        {
            if (rights == Rights.Type.None && (!src.Rights.TryGetValue(dst.Id, out rights) || rights == Rights.Type.None)) return;

            var midX = (src.X + dst.X) / 2;
            var midY = (src.Y + dst.Y) / 2;

            var pen = dashed ? dashedPen : solidPen;
            if (curved)
            {
                var points = new Point[]
                {
                    new Point(src.X, src.Y - src.Radius),
                    new Point(canvas.Size.Width / 2, canvas.Height / 4),
                    new Point(dst.X, dst.Y - dst.Radius),
                };
                g.DrawCurve(pen, points);

                midX = points[1].X;
                midY = points[1].Y;
            }
            else
            {
                g.DrawLine(pen, src.GetEdgePosition(dst.Pos), dst.GetEdgePosition(src.Pos));
            }

            var font = new Font(FontFamily.GenericSansSerif, 8);
            g.DrawString(Rights.ToString(rights), font, Brushes.Blue, midX, midY);
        }

        private enum GraphType
        {
            None,
            Take,
            Grant
        }
    }
}
