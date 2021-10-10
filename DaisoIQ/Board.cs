using System.Text;

namespace DaisoIQ {
    public class Board {
        private const int SIZE = 10;
        private const char OPENING = '_';

        private char[,] grid = new char[SIZE, SIZE];

        private Board() { }

        public static Board Init() {
            var board = new Board();
            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j <= i; j++) {
                    board.grid[i, j] = OPENING;
                }
            }

            return board;
        }

        public Point NextFree() {
            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j <= i; j++) {
                    if (grid[i, j] == OPENING) {
                        return new Point(i, j);
                    }
                }
            }

            return new Point(-1, -1);
        }

        public bool CheckPiece(Piece piece, in Point start) {
            foreach (Point p in piece.Offsets) {
                int x = p.X + start.X;
                int y = p.Y + start.Y;
                if (x is >= SIZE or < 0 || y is >= SIZE or < 0) {
                    return false;
                }
                if (grid[x, y] != OPENING) {
                    return false;
                }
            }
            
            return true;
        }
        
        public void WritePiece(Piece piece, in Point start, char c) {
            foreach (Point p in piece.Offsets) {
                grid[p.X + start.X, p.Y + start.Y] = c;
            }
        }
        
        public Board Clone() {
            var board = new Board();
            board.grid = (char[,]) grid.Clone();
            return board;
        }

        public override string ToString() {
            var builder = new StringBuilder();
            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j <= i; j++) {
                    builder.Append(grid[i, j]);
                }
                builder.AppendLine("-");
            }
            
            // remove trailing newline
            builder.Remove(builder.Length - 1, 1);
            return builder.ToString();
        }
    }
}
