using System;

public class Point2D
{
    protected float x = 0.0f;
    protected float y = 0.0f;

    public Point2D() { }

    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float GetX()
    {
        return x;
    }

    public void SetX(float x)
    {
        this.x = x;
    }

    public float GetY()
    {
        return y;
    }

    public void SetY(float y)
    {
        this.y = y;
    }

    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float[] GetXY()
    {
        return new float[] { x, y };
    }

    public override string ToString()
    {
        return $"({x},{y})";
    }
}
