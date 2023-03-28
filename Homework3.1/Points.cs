class Point 
{
    private float x;
    private float y;
    public Point(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float GetX() 
    {
        return this.x;
    }
    public float GetY() 
    {
        return this.y;
    }
    public void SetX(float InputX)
    {
        this.x = InputX; 
    }
    public void SetY(float InputY)
    {
        this.y = InputY; 
    }
}