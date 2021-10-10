namespace DaisoIQ {
    public readonly struct Point {
        public readonly int X;
        public readonly int Y;
        
        public Point(int x, int y) {
            X = x;
            Y = y;
        }
        
        public static implicit operator Point((int X, int Y) t) {
            return new Point(t.X, t.Y);
        }

        public static Point operator +(Point a, Point b) {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
    }
}
