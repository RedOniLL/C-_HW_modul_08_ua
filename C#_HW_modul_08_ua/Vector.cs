using System;


namespace C__HW_modul_08_ua
{
    struct Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        
        public Vector MultiplyByScalar(double scalar) => new Vector(X * scalar, Y * scalar, Z * scalar);
       
        public Vector Add(Vector otherVector) => new Vector(X + otherVector.X, Y + otherVector.Y, Z + otherVector.Z);
      
        public Vector Subtract(Vector otherVector) => new Vector(X - otherVector.X, Y - otherVector.Y, Z - otherVector.Z);

        
        public double Length() => Math.Sqrt(X * X + Y * Y + Z * Z);
     

       
        public override string ToString() => $"({X}, {Y}, {Z})";
       
    }
}
