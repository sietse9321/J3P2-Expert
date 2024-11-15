namespace CSharp_Expert.Opdracht1;

using Microsoft.Xna.Framework;

public class TransformComp
{
    private Vector2 _position;
    private float _rotation;

    public float Rotation
    {
        get => _rotation;
        set => _rotation = value % 360;
    }
    //yooooo

    public Vector2 Position
    {
        get => _position;
        set => _position = value;
    }
    public void RotationToRadians()
    {
        Rotation = MathHelper.ToRadians(_rotation);
    }
}