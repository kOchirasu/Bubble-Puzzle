using System.Collections.Generic;
using System.Text;

namespace DaisoIQ {
    public class Piece {
        private const int SIZE = 4;

        public readonly Point Origin;
        public List<Point> Offsets;

        public Piece(Point origin, params Point[] offsets) {
            Origin = origin;
            Offsets = new List<Point>(offsets.Length + 1);
            Offsets.Add((0, 0));
            Offsets.AddRange(offsets);
        }

        public override string ToString() {
            char[,] grid = new char[SIZE, SIZE];
            foreach (Point p in Offsets) {
                grid[Origin.X + p.X, Origin.Y + p.Y] = 'O';
            }
            grid[Origin.X, Origin.Y] = '0';

            var builder = new StringBuilder();
            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j < SIZE; j++) {
                    if (grid[i, j] == default) {
                        builder.Append('X');
                    } else {
                        builder.Append(grid[i, j]);
                    }
                }
                builder.AppendLine();
            }
            
            // remove trailing newline
            builder.Remove(builder.Length - 1, 1);
            return builder.ToString();
        }
    }
}
