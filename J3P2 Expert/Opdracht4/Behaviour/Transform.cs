using CSharp_Expert.Opdracht4.Components;
using Microsoft.Xna.Framework;

namespace CSharp_Expert.Opdracht4.Behaviour;

public class Transform : Component
{
    private float _rotation;
    private Vector2 _position;
    private Vector2 _scale;
    private Vector2 _origin;

    public Transform()
    {
        Rotation = 0;
        Position = Vector2.Zero;
        Scale = new Vector2(1f, 1f);
        Origin = new Vector2(0.5f, 0.5f);
    }

    public float Rotation
    {
        get => _rotation; //if number is above 360 make it 0
        set => _rotation = value /*% 360*/;
    }

    public Vector2 Position
    {
        get => _position;
        set => _position = value;
    }

    public Vector2 Scale
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