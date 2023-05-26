using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TakeGrant.Model;

namespace TakeGrant.View
{
    public class ItemView
    {
        private readonly Pen pen = Pens.Black;

        private Point pos;
        private int radius = 12;

        private readonly Item item;

        public ItemView(int x, int y, Item item) : this(new Point(x, y), item) { }

        public ItemView(Point position, Item item)
        {
            this.pos = position;
            this.item = item;
        }

        public int Id => item.Id;
        public Point Pos => pos;
        public int X => pos.X;
        public int Y => pos.Y;
        public int Radius => radius;

        public bool IsObject => item.IsObject;

        public IReadOnlyDictionary<int, Rights.Type> Rights => item.AccessRights;

        public Point GetEdgePosition(Point src)
        {
            var vx = src.X - pos.X;
            var vy = src.Y - pos.Y;
            var d = Math.Sqrt(Math.Pow(vx, 2) + Math.Pow(vy, 2));
            var k = radius / d;

            return new Point((int)(pos.X + vx * k), (int)(pos.Y + vy * k));
        }

        public void Draw(Graphics g)
        {
            var font = new Font(FontFamily.GenericSansSerif, 8);

            var d = 2 * radius;
            var brush = !IsObject ? Brushes.Black : Brushes.White;

            g.FillEllipse(brush, X - radius, Y - radius, d, d);
            g.DrawEllipse(pen, X - radius, Y - radius, d, d);

            TextRenderer.DrawText(
                g, item.ShortName, font,
                new Rectangle(X - radius, Y - radius, d, d),
                !IsObject ? Color.White : Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
