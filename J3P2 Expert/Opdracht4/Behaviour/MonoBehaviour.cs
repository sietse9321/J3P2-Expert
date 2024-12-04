using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CSharp_Expert.Opdracht4.BaseClass;

namespace CSharp_Expert.Opdracht4.Behaviour;
public class MonoBehaviour
{
    protected GameObject _gameObject;

    /// <summary>
    /// assigns the gameobject to the monobehaviour
    /// </summary>
    /// <param name="gameObject"></param>
    public void Assign(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    //update and draw for the behaviour
    public virtual void Update(GameTime gameTime) { }
    public virtual void Draw(SpriteBatch spriteBatch, Transform transform) { }
}