namespace CSharp_Expert.Opdracht1;

using Microsoft.Xna.Framework;

public class TransformComp
{
    private float _rotation;
    private Vector2 _position;
    private float _scale;
    private Vector2 _origin;

    /// <summary>
    /// default values for transform
    /// </summary>
    public TransformComp()
    {
        Rotation = 0;
        Position = Vector2.Zero;
        Scale = 1f;
        Origin = new Vector2(0.5f, 0.5f);
    }
    //getter and setter encapsulation
    public float Rotation
    {
        get => _rotation;   //if number is above 360 make it 0
        set => _rotation = value /*% 360*/;
    }
    public Vector2 Position
    {
        get => _position;
        set => _position = value;
    }
    public float Scale
    {
        get => _scale;
        set => _scale = value;
    }
    public Vector2 Origin
    {
        get => _origin;
        set => _origin = value;
    }
}