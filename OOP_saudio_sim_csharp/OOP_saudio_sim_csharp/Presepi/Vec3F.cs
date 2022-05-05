using System;

namespace OOP_saudio_sim_csharp.Presepi
{
    public class Vec3F
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vec3F(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vec3F(float value) : this(value, value, value)
        {
        }

        public override string ToString() => "X:" + this.X + "Y:" + this.Y + "Z:" + this.Z;
        
        public override int GetHashCode()
        {
            return HashCode.Combine(this.X, this.Y, this.Z);
        }
        
        /// <inheritdoc cref="IEquatable{T}.Equals(T)"/>
        public bool Equals(Vec3F other)
        {
            return this.X.CompareTo(other.X)==0;
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (this == obj)
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals(obj as Vec3F);
        }
    }
}