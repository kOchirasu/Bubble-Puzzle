using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DaisoIQ {
    public static class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            var white = new PieceSet("white", 1, new List<Piece> {
                new Piece((0, 1), (1, -1), (1, 0), (1, 1), (2, 0)),
            });
            var pink = new PieceSet("pink", 2, new List<Piece> {
                new Piece((0, 0), (0, 1), (1, 0), (1, 1)),
            });
            var yellow = new PieceSet("yellow", 3, new List<Piece> {
                new Piece((0, 0), (0, 1), (0, 2), (0, 3)),
                new Piece((0, 0), (1, 0), (2, 0), (3, 0)),
            });
            var red = new PieceSet("red", 4, new List<Piece> {
                new Piece((0, 0), (0, 1), (1, 1), (1, 2), (2, 2)),
                new Piece((0, 2), (1, -1), (1, 0), (2, -2), (2, -1)),
                new Piece((0, 0), (1, 0), (1, 1), (2, 1), (2, 2)),
                new Piece((0, 1), (0, 1), (1, -1), (1, 0), (2, -1)),
            });
            var darkRed = new PieceSet("dark_red", 5, new List<Piece> {
                new Piece((0, 0), (0, 1), (1, 1)),
                new Piece((0, 1), (1, 0), (1, -1)),
                new Piece((0, 0), (1, 0), (1, 1)),
                new Piece((0, 0), (0, 1), (1, 0)),
            });
            var purple = new PieceSet("purple", 6, new List<Piece> {
                new Piece((0, 0), (0, 1), (0, 2), (1, 2), (2, 2)),
                new Piece((0, 0), (0, 1), (0, 2), (1, 0), (2, 0)),
                new Piece((0, 0), (1, 0), (2, 0), (2, 1), (2, 2)),
                new Piece((0, 2), (1, 0), (2, 0), (2, -1), (2, -2)),
            });
            var blue = new PieceSet("blue", 7, new List<Piece> {
                new Piece((0, 0), (0, 1), (0, 2), (1, 0), (1, 2)),
                new Piece((0, 0), (0, 1), (1, 1), (2, 0), (2, 1)),
                new Piece((0, 0), (0, 2), (1, 0), (1, 1), (1, 2)),
                new Piece((0, 0), (0, 1), (1, 0), (2, 0), (2, 1)),
            });
            var orange = new PieceSet("orange", 8, new List<Piece> {
                new Piece((0, 0), (0, 1), (1, 0), (2, 0)),
                new Piece((0, 0), (0, 1), (0, 2), (1, 2)),
                new Piece((0, 1), (1, 0), (2, 0), (2, -1)),
                new Piece((0, 0), (1, 0), (1, 1), (1, 2)),
                
                new Piece((0, 0), (0, 1), (1, 1), (2, 1)),
                new Piece((0, 2), (1, 0), (1, -1), (1, -2)),
                new Piece((0, 0), (1, 0), (2, 0), (2, 1)),
                new Piece((0, 0), (0, 1), (0, 2), (1, 0)),
            });
            var lightBlue = new PieceSet("light_blue", 9, new List<Piece> {
                new Piece((0, 0), (0, 1), (0, 2), (1, 1), (1, 2)),
                new Piece((0, 1), (1, -1), (1, 0), (2, -1), (2, 0)),
                new Piece((0, 0), (0, 1), (1, 0), (1, 1), (1, 2)),
                new Piece((0, 0), (0, 1), (1, 0), (1, 1), (2, 0)),
                
                new Piece((0, 0), (0, 1), (0, 2), (1, 0), (1, 1)),
                new Piece((0, 0), (0, 1), (1, 0), (1, 1), (2, 1)),
                new Piece((0, 1), (0, 1), (1, -1), (1, 0), (1, 1)),
                new Piece((0, 0), (1, 0), (1, 1), (2, 0), (2, 1)),
            });
            var darkBlue = new PieceSet("dark_blue", 10, new List<Piece> {
                new Piece((0, 1), (0, 1), (0, 2), (1, -1), (1, 0)),
                new Piece((0, 0), (1, 0), (1, 1), (2, 1), (3, 1)),
                new Piece((0, 2), (0, 1), (1, -2), (1, -1), (1, 0)),
                new Piece((0, 0), (1, 0), (2, 0), (2, 1), (3, 1)),
                
                new Piece((0, 0), (0, 1), (0, 2), (1, 2), (1, 3)),
                new Piece((0, 1), (1, 0), (2, -1), (2, 0), (3, -1)),
                new Piece((0, 0), (0, 1), (1, 1), (1, 2), (1, 3)),
                new Piece((0, 1), (1, -1), (1, 0), (2, -1), (3, -1)),
            });
            var green = new PieceSet("green", 11, new List<Piece> {
                new Piece((0, 0), (0, 1), (1, 0), (2, 0), (3, 0)),
                new Piece((0, 0), (0, 1), (0, 2), (0, 3), (1, 3)),
                new Piece((0, 1), (1, 0), (2, 0), (3, 0), (3, -1)),
                new Piece((0, 0), (1, 0), (1, 1), (1, 2), (1, 3)),
                
                new Piece((0, 0), (0, 1), (1, 1), (2, 1), (3, 1)),
                new Piece((0, 3), (1, -3), (1, -2), (1, -1), (1, 0)),
                new Piece((0, 0), (1, 0), (2, 0), (3, 0), (3, 1)),
                new Piece((0, 0), (0, 1), (0, 2), (0, 3), (1, 0)),
            });
            var darkGreen = new PieceSet("dark_green", 12, new List<Piece> {
                new Piece((0, 0), (0, 1), (0, 2), (0, 3), (1, 2)),
                new Piece((0, 1), (1, 0), (2, -1), (2, 0), (3, 0)),
                new Piece((0, 1), (1, -1), (1, 0), (1, 1), (1, 2)),
                new Piece((0, 0), (1, 0), (1, 1), (2, 0), (3, 0)),
                
                new Piece((0, 0), (0, 1), (0, 2), (0, 3), (1, 1)),
                new Piece((0, 1), (1, -1), (1, 0), (2, 0), (3, 0)),
                new Piece((0, 2), (1, -2), (1, -1), (1, 0), (1, 1)),
                new Piece((0, 0), (1, 0), (2, 0), (2, 1), (3, 0)),
            });

            /*1 white
            2 pink
            3 yellow
            4 red
            5 dark_red
            6 purple
            7 blue
            8 orange
            9 light_blue
            A dark_blue
            B green
            C dark_green*/
            PieceSet[] pieces = {
                lightBlue,  // 9
                darkRed,    // 5
                darkBlue,   // A
                orange,     // 8
                red,        // 4
                white,      // 1
                yellow,     // 3
                green,      // B
                blue,       // 7
                purple,     // 6
                pink,       // 2
                darkGreen   // C
            };
            Shuffle(new Random(), pieces);


            /*foreach (var p in white.Orientations) {
                Console.WriteLine(p);
                Console.WriteLine();
            }*/

            Board b = Board.Init();

            var sw = new Stopwatch();
            sw.Start();
            Solve(b, pieces);
            Console.WriteLine($"time: {sw.ElapsedMilliseconds}ms");
            Console.WriteLine("Hello World!");
        }

        private static int progress = 0;
        private static List<Board> solutions = new List<Board>();
        
        private static void Solve(Board board, PieceSet[] pieces) {
            Point next = board.NextFree();
            if (next.X < 0) {
                Console.WriteLine($"=======SOLVED {solutions.Count}====== {Environment.TickCount}");
                Console.WriteLine(board);
                solutions.Add(board);
                return;
            }

            var remaining = (PieceSet[]) pieces.Clone();
            for (int i = 0; i < remaining.Length; i++) {
                // Piece already used
                if (remaining[i] == null) {
                    continue;
                }
                
                foreach (Piece piece in remaining[i].Orientations) {
                    //Console.WriteLine($"Trying {remaining[i]}");
                    if (board.CheckPiece(piece, next)) {
                        Board cloned = board.Clone();
                        cloned.WritePiece(piece, next, remaining[i].Id);
                        /*progress++;
                        if (progress > 1 && remaining[i].Id == '5') {
                            Console.WriteLine($"==={progress}===");
                            Console.WriteLine(cloned);
                            Thread.Sleep(200);
                        }*/
                        PieceSet save = remaining[i];
                        // Set null so this piece is not used again
                        remaining[i] = null;
                        Solve(cloned, remaining);
                        // if solve returns, we are not using this piece
                        // restore it for use again
                        remaining[i] = save;
                    }
                }
            }
        }
        
        public static void Shuffle<T>(this Random rng, T[] array) {
            int n = array.Length;
            while (n > 1) {
                int k = rng.Next(n--);
                (array[n], array[k]) = (array[k], array[n]);
            }
        }
    }
}
