using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using CSharp_Expert.Opdracht3.Behaviour;


namespace CSharp_Expert.Opdracht3.BaseClass;

public class GameObject
{
    private Transform _transform;
    private List<MonoBehaviour> _components = [];

    //Properties
    public Transform Transform
    {
        get => _transform;
        set => _transform = value;
    }

    public GameObject(Texture2D texture, params MonoBehaviour[] components)
    {
        //new transform instance
        Transform = new Transform();
        //adds all the components
        for (int i = 0; i < components.Length; i++)
        {
            MonoBehaviour component = components[i];
            _components.Add(component);
            component.Assign(this);
        }
    }

    public void Update(GameTime gameTime)
    {
        //for each component in list update
        foreach (MonoBehaviour component in _components)
        {
            component.Update(gameTime);
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        //for each component in list draw
        foreach (MonoBehaviour component in _components)
        {
            component.Draw(spriteBatch, _transform);
        }
    }

    public void AddComponent(MonoBehaviour pBehaviour){}

    public void RemoveComponent(MonoBehaviour pBehaviour){}

    //method to get a specific monobehavior in compontents list
    public T GetComponent<T>() where T : MonoBehaviour
    {
        for (int i = 0; i < _components.Count; i++)
        {
            if (_components[i] is T behaviour) //Also finds inherited class types (GetComponent<MonoBehaviour>() will return every component which is a MonoBehaviour or a child class of MonoBehaviour
            {
                return behaviour;
            }

            //if (_components[i].GetType() == typeof(T))//Only finds specifically requested class types (GetComponent<MonoBehaviour>() will return only components which are of type MonoBehaviour, no child classes of MonoBehaviour
            //{
            //    return (T)_components[i];
            //}
        }

        return null;
    }
}
// public void AddTextRenderer(SpriteFont font, string text, Color color)
// {
//     //TextRenderer = new TextRendererComp(font, text, color);
// }