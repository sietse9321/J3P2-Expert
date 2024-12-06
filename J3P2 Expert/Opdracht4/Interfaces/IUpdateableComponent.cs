using Microsoft.Xna.Framework;

namespace CSharp_Expert.Opdracht4.Interfaces;

public interface IUpdateableComponent
{
    void Update(GameTime gameTime);
    //void LateUpdate(GameTime gameTime);
}