﻿using System.Collections.Generic;
using CSharp_Expert.opdracht1;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht1;
public abstract class SceneBase
{
    protected List<GameObject> GameObjects { get; private set; }

    public SceneBase()
    {
        GameObjects = new List<GameObject>();
    }

    public virtual void Initialize()
    {
    }

    public void ClearObjects()
    {
        GameObjects.Clear();
    }
    public virtual void Update(GameTime gameTime)
    {
        foreach (var gameObject in GameObjects)
        {
            gameObject.Update(gameTime);
        }
    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        foreach (var gameObject in GameObjects)
        {
            gameObject.Draw(spriteBatch);
        }
    }
}
