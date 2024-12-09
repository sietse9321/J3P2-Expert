using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using CSharp_Expert.Opdracht4.Behaviour;
using CSharp_Expert.Opdracht4.Components;
using CSharp_Expert.Opdracht4.Interfaces;
using System;


namespace CSharp_Expert.Opdracht4.BaseClass;

public class GameObject
{
    private Transform _transform;

    private List<Component> _allComponents = [];
    private List<IUpdateableComponent> _updateableComponents = [];
    private List<IDrawableComponent> _drawableComponents = [];
    
    //Properties
    public Transform Transform
    {
        get => _transform;
        set => _transform = value;
    }

    public GameObject(params Component[] components)
    {
        //new transform instance
        Transform = new Transform();
        //adds all the components
        for (int i = 0; i < components.Length; i++)
        {
            //method addcomponent
            Component component = components[i];
            AddComponent(component);
        }
    }

    public void Update(GameTime gameTime)
    {
        //for each component in list update
        foreach (IUpdateableComponent component in _updateableComponents)
        {
            component.Update(gameTime);
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        //for each component in list draw
        foreach (IDrawableComponent component in _drawableComponents)
        {
            component.Draw(spriteBatch);
        }
    }

    public void AddComponent(Component pComponent)
    {
        _allComponents.Add(pComponent);
        pComponent.Assign(this);

        if (pComponent is IDrawableComponent drawable)
        {
            //Console.WriteLine("draw true");
            _drawableComponents.Add(drawable);
        }

        if (pComponent is IUpdateableComponent updateable)
        {
            //Console.WriteLine("update true");
            _updateableComponents.Add(updateable);
        }
        if (pComponent is MonoBehaviour monoBehaviour)
        {
            monoBehaviour.Awake();
        }

    }

    public void RemoveComponent(Component pComponent)
    {
        _allComponents.Remove(pComponent);
        if (pComponent is IDrawableComponent drawable)
        {
            _drawableComponents.Remove(drawable);
        }

        if (pComponent is IUpdateableComponent updateable)
        {
            _updateableComponents.Remove(updateable);
        }
    }

    //method to get a specific monobehavior in compontents list
    public T GetComponent<T>() where T : Component
    {
        for (int i = 0; i < _allComponents.Count; i++)
        {
            if (_allComponents[i] is T behaviour) //Also finds inherited class types (GetComponent<MonoBehaviour>() will return every component which is a MonoBehaviour or a child class of MonoBehaviour
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