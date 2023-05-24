using System.Collections.Generic;
using System.Drawing;
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

        private Queue<Item> itemsToCreate;
        
        public GraphDrawer(PictureBox canvas, Label messageLabel) 
        { 
            items = new Dictionary<int, ItemView>();

            this.canvas = canvas;
            this.messageLabel = messageLabel;

            canvas.MouseUp += ClickCallback;
            canvas.Paint += Draw;
        }

        ~GraphDrawer()
        {
            canvas.MouseUp -= ClickCallback;
            canvas.Paint -= Draw;
        }

        public void Init(IEnumerable<Item> modelItems)
        {
            this.items.Clear();
            
            this.itemsToCreate = new Queue<Item>(modelItems);
            
            RequestItemPosition();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            foreach (var item in items.Values)
            {
                foreach (var right in item.Rights)
                {
                    if (items.TryGetValue(right.Key, out var srcItem))
                        DrawArrow(e.Graphics, 
                            item.GetEdgePosition(srcItem.Pos), 
                            srcItem.GetEdgePosition(item.Pos), 
                            Rights.ToString(right.Value));
                }
            }

            foreach (var item in items.Values)
            {
                item.Draw(e.Graphics);
            }
        }

        private void ClickCallback(object sender, MouseEventArgs e)
        {
            if (itemsToCreate == null || itemsToCreate.Count <= 0)
                return;

            Item item = null;
            while (itemsToCreate.Count > 0)
            {
                item = itemsToCreate.Dequeue();
                if (!items.ContainsKey(item.id)) break;
                item = null;
            }

            if (item != null)
            {
                var viewItem = new ItemView(e.X, e.Y, item.Rights, item.ShortName);
                items[item.id] = viewItem;
            }

            RequestItemPosition();
        }

        private void RequestItemPosition()
        {
            canvas.Invalidate();
            
            if (itemsToCreate.Count <= 0)
            {
                messageLabel.Text = "";
                return;
            }

            var item = itemsToCreate.Peek();
            messageLabel.Text = string.Format(requestPointMessage, item);
        }

        private void DrawArrow(Graphics g, Point src, Point dst, string rights)
        {
            g.DrawLine(Pens.Black, src, dst);
            g.FillEllipse(Brushes.Yellow, dst.X, dst.Y, 10, 10);

            var midX = (src.X + dst.X) / 2;
            var midY = (src.Y + dst.Y) / 2;

            var font = new Font(FontFamily.GenericSansSerif, 8);
            g.DrawString(rights, font, Brushes.Blue, midX, midY);
        }
    }
}
