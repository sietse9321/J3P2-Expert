using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CSharp_Expert.Opdracht4.BaseClass;

namespace CSharp_Expert.Opdracht4.Behaviour;
public class MonoBehaviour
{
    protected GameObject _gameObject;

    public void Assign(GameObject gameObject)
    {
        _gameObject = gameObject;
    }
    public virtual void Update(GameTime gameTime) { }
    public virtual void Draw(SpriteBatch spriteBatch, Transform transform) { }
}