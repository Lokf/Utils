using System;

namespace Lokf.Utils.Types
{
    public class Unit : IEquatable<Unit>, IComparable<Unit>
    {
        public int CompareTo(Unit other) => 0;

        public override bool Equals(object other) => other is Unit;

        public override string ToString() => "()";

        public override int GetHashCode() => 0;

        public bool Equals(Unit other) => true;

        public static bool operator ==(Unit first, Unit second) => true;

        public static bool operator !=(Unit first, Unit second) => false;

        public static Unit Default() => default(Unit);
    }
}
