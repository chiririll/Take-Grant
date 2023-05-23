using System.Drawing;

namespace TakeGrant.View
{
    public class ItemView
    {
        private readonly Pen pen = Pens.Black;
        
        private Point pos;
        private int radius = 10;
        
        public ItemView(int x, int y) : this(new Point(x, y)) { }

        public ItemView(Point position) 
        { 
            this.pos = position;
        }

        public int X => pos.X;
        public int Y => pos.Y;

        public Point GetEdgePosition(Point src)
        {
            return new Point(X, Y);
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
            g.DrawEllipse(pen, X, Y, radius, radius);
            // TODO: Draw text
        }
    }
}
