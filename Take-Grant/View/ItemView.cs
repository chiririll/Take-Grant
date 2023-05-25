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
        
        public ItemView(int x, int y, IReadOnlyDictionary<int, Rights.Type> rights, string name) : this(new Point(x, y), rights, name) { }

        public ItemView(Point position, IReadOnlyDictionary<int, Rights.Type> rights, string name) 
        { 
            this.pos = position;
            this.Rights = rights;
            this.Name = name;
        }

        public Point Pos => pos;
        public int X => pos.X;
        public int Y => pos.Y;

        public bool IsObject => Rights.Count == 0;

        public string Name { get; private set; }
        public IReadOnlyDictionary<int, Rights.Type> Rights { get; private set; }

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
            var brush = IsObject ? Brushes.Black : Brushes.White;

            g.FillEllipse(brush, X - radius, Y - radius, d, d);
            g.DrawEllipse(pen, X - radius, Y - radius, d, d);

            TextRenderer.DrawText(
                g, Name, font,
                new Rectangle(X - radius, Y - radius, d, d),
                IsObject ? Color.White : Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
