using System.Collections.Generic;
using System.Drawing;
using TakeGrant.Model;

namespace TakeGrant.View
{
    public class ItemView
    {
        private readonly Pen pen = Pens.Black;
        
        private Point pos;
        private int radius = 25;
        
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

        public string Name { get; private set; }
        public IReadOnlyDictionary<int, Rights.Type> Rights { get; private set; }

        public Point GetEdgePosition(Point src)
        {
            return new Point(X + radius / 2, Y + radius / 2);
            // TODO
            throw new System.NotImplementedException();
        }

        public bool CheckClick(Point click)
        {
            return X - radius < click.X && click.X < X + radius &&
                Y - radius < click.Y && click.Y < Y + radius;
        }

        public void Draw(Graphics g)
        {
            var font = new Font(FontFamily.GenericSansSerif, 8);
            
            g.FillEllipse(Brushes.White, X, Y, radius, radius);
            g.DrawEllipse(pen, X, Y, radius, radius);

            g.DrawString(Name, font, Brushes.Black, pos.X + 2, pos.Y + 6);

            // TODO: Draw text
        }
    }
}
