using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Point
{
    public int x;
    public int y;

    public Point(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public Vector2 ToVector()
    {
        return new Vector2(x, y);
    }

    public bool Equals(Point point)
    {
        return (x == point.x && y == point.y);
    }

    public static Point fromVector(vector2 v)
    {
        return new Point((int)v.x, (int)v.y);
    }

    public static Point fromVector(vector3 v)
    {
        return new Point((int)v.x, (int)v.y);
    }

    public static Point multiplecation(Point point, int multiplier)
    {
        return new Point(point.x * multiplier, point.y * multiplier);
    }

    public static Point add(Point point, int o)
    {
        return new Point(point.x + o.x, point.y + o.y);
    }

    public static Point clone(Point point)
    {
        return new Point(point.x, point.y);
    }
}
