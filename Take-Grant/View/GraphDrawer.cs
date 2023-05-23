using System.Collections.Generic;
using System.Windows.Forms;
using TakeGrant.Model;
using TakeGrant.View;

namespace TakeGrant
{
    public class GraphDrawer
    {
        private const string requestPointMessage = "Поставьте точку для {0}";

        private readonly Dictionary<int, ItemView> items;

        private readonly PictureBox canvas;
        private readonly Label messageLabel;

        private GraphInitializer<Item> initializer;

        public GraphDrawer(PictureBox canvas, Label messageLabel) 
        { 
            items = new Dictionary<int, ItemView>();

            this.canvas = canvas;
            this.messageLabel = messageLabel;

            this.initializer = null;

            canvas.MouseUp += ClickCallback;
            canvas.Paint += Draw;
        }

        ~GraphDrawer()
        {
            canvas.MouseUp -= ClickCallback;
            canvas.Paint -= Draw;
        }

        public void Init(IReadOnlyList<Item> modelItems)
        {
            this.items.Clear();
            
            initializer = new GraphInitializer<Item>(modelItems);
            RequestItemPosition();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            foreach (var item in items.Values)
            {
                item.Draw(e.Graphics);
            }
        }

        private void ClickCallback(object sender, MouseEventArgs e)
        {
            if (initializer == null)
                return;

            var item = initializer.GetItem();
            var viewItem = new ItemView(e.X, e.Y);

            items[item.id] = viewItem;

            if (initializer.IsOver())
                initializer = null;

            RequestItemPosition();
        }

        private void RequestItemPosition()
        {
            canvas.Invalidate();
            
            if (initializer == null)
            {
                messageLabel.Text = "";
                return;
            }

            var item = initializer.PeekItem();
            messageLabel.Text = string.Format(requestPointMessage, item.id);
        }
    }
}
