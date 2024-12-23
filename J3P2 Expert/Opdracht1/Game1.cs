﻿using System;
using System.Collections.Generic;
using CSharp_Expert.Opdracht1.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CSharp_Expert.Opdracht1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Texture2D _starTexture;
    private SceneBase _currentScene;
    private List<SceneBase> _scenes = new List<SceneBase>();


    private SpriteFont _font;


    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        _graphics.PreferredBackBufferWidth = 800;
        _graphics.PreferredBackBufferHeight = 600;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _starTexture = Content.Load<Texture2D>("LittleStar");
        _font = Content.Load<SpriteFont>("font");
        PositionTestScene position = new PositionTestScene(_starTexture, _font);
        RotationTestScene rotation = new RotationTestScene(_starTexture, _font);
        ScaleTestScene scale = new ScaleTestScene(_starTexture, _font);
        OriginTestScene origin = new OriginTestScene(_starTexture, _font);

        _scenes.Add(position);
        _scenes.Add(rotation);
        _scenes.Add(scale);
        _scenes.Add(origin);

        _currentScene = _scenes[0];

        _currentScene.Initialize();


        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        // TODO: Add your update logic here

        KeyInput();
        _currentScene.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin(SpriteSortMode.FrontToBack);
        _currentScene.Draw(_spriteBatch);
        _spriteBatch.End();

        base.Draw(gameTime);
    }

    private void KeyInput()
    {
        KeyboardState keyboardState = Keyboard.GetState();
        if (keyboardState.IsKeyDown(Keys.D1))
        {
            ChangeScene(0);
        }
        if (keyboardState.IsKeyDown(Keys.D2))
        {
            ChangeScene(1);
        }
        if (keyboardState.IsKeyDown(Keys.D3))
        {
            ChangeScene(2);
        }
        if (keyboardState.IsKeyDown(Keys.D4))
        {
            ChangeScene(3);
        }
    }
    private void ChangeScene(int pScene)
    {
        _currentScene.ClearObjects();
        _currentScene = _scenes[pScene];
        _currentScene.Initialize();
    }
}