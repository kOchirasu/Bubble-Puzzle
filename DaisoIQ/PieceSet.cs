using System.Collections.Generic;

namespace DaisoIQ {
    public class PieceSet {
        public readonly string Name;
        public readonly char Id;
        public readonly List<Piece> Orientations;

        public PieceSet(string name, int id, List<Piece> orientations) {
            Name = name;
            Id = id.ToString("X").ToCharArray()[0];
            Orientations = orientations;
        }

        public override string ToString() {
            return Name;
        }
    }
}
