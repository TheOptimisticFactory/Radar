using System;

namespace Radar;

public readonly struct Vector2d
{
    public readonly double X;
    public readonly double Y;

    public Vector2d(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Length => Math.Sqrt(X * X + Y * Y);

    public static Vector2d operator -(Vector2d v1, Vector2d v2)
    {
        return new Vector2d(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static Vector2d operator +(Vector2d v1, Vector2d v2)
    {
        return new Vector2d(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector2d operator /(Vector2d v, double d)
    {
        return new Vector2d(v.X / d, v.Y / d);
    }
}
