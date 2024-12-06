using Microsoft.Xna.Framework;
using CSharp_Expert.Opdracht4.Components;
using CSharp_Expert.Opdracht4.Interfaces;

namespace CSharp_Expert.Opdracht4.Behaviour;
public abstract class MonoBehaviour : Component, IUpdateableComponent
{
    public virtual void Update(GameTime gameTime) { }
}