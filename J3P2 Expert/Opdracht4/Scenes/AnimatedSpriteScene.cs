using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using CSharp_Expert.Opdracht4.BaseClass;
using CSharp_Expert.Opdracht4.Behaviour;
using CSharp_Expert.Opdracht4.Components;

namespace CSharp_Expert.Opdracht4.Scenes;

public class AnimatedSpriteScene : SceneBase
{
    private Texture2D[] _textures;
    //Prefabs to Instantiate from
    private Rotater _rotatorPrefab;
    private Bouncer _bouncerPrefab;
    private Scaler _scalerPrefab;
    private ColorShifter _colorShifterPrefab;

    public AnimatedSpriteScene(GraphicsDeviceManager graphics, Texture2D[] objectTexture, SpriteFont font) : base(graphics)
    {
        //TODO Create 4 prefabs
        _textures = objectTexture;
         _rotatorPrefab = new Rotater(1f, false);
        _bouncerPrefab = new Bouncer(1, new Vector2(0f, -1f), 100f);
        _scalerPrefab = new Scaler(0.5f, new Vector2(0.2f, 0.2f), new Vector2(1f, 1f));
        _colorShifterPrefab = new ColorShifter(1f);
    }

    protected void CreateObject(Vector2 pPosition, PrefabComponent pType, Texture2D pTexture, int hCount, int wCount,float speed ,Color color ,int start, int end, Vector2 scale = default, float layerDepth = 0.09f)
    {
        if (scale == default) scale = new Vector2 (1f, 1f);
        List<MonoBehaviour> components = new List<MonoBehaviour>();

        //check type has flag
        if (pType.HasFlag(PrefabComponent.Rotater))
        {
            //create a new instance
            components.Add(new Rotater(1f, false));
        }

        if (pType.HasFlag(PrefabComponent.Bouncer))
        {
            components.Add(new Bouncer(1, new Vector2(0f, -1f), 100f));
        }

        if (pType.HasFlag(PrefabComponent.Scaler))
        {
            components.Add(new Scaler(0.5f, new Vector2(0.2f, 0.2f), new Vector2(1f, 1f)));
        }

        if (pType.HasFlag(PrefabComponent.ColorShifter))
        {
            components.Add(new ColorShifter(1f));
        }

        //creates a new object with the given parameters
        GameObject newGameObject = new GameObject(components.ToArray());
        newGameObject.Transform.Position = pPosition;
        newGameObject.Transform.Scale = scale;
        newGameObject.AddComponent(new AnimatedSpriteRenderer(pTexture, hCount, wCount, speed, color, 0.9f, start, end, 5));
        GameObjects.Add(newGameObject);
    }

    public override void Initialize()
    {
        CreateObject(new Vector2(300, 300), PrefabComponent.ColorShifter, _textures[0], 5, 2, 0.06f , Color.White, 0, 9);
        CreateObject(new Vector2(300, 450), 0, _textures[0], 5, 2, 0.12f, Color.White, 0, 9);
        CreateObject(new Vector2(500, 300), PrefabComponent.ColorShifter, _textures[0], 5, 2, 0.06f, Color.White, 0, 9);
        CreateObject(new Vector2(500, 450), 0, _textures[0], 5, 2, 0.12f, Color.White, 0, 9);
        CreateObject(new Vector2(700, 300), 0, _textures[0], 5, 2, 0.06f, Color.DarkGreen, 0, 9, new Vector2(2f,2f));
        CreateObject(new Vector2(700, 450), 0, _textures[0], 5, 2, 0.24f, Color.Red, 0, 9);


        CreateObject(new Vector2(150, 150), 0, _textures[1], 11, 13, 0.06f, Color.White, 0, 142, new Vector2(3f, 3f));
        CreateObject(new Vector2(1130, 150), 0, _textures[1], 11, 13, 0.12f, Color.White, 0, 142, new Vector2(3f, 1.5f),0.3f);
        CreateObject(new Vector2(1130, 200), 0, _textures[1], 11, 13, 0.06f, Color.White, 0, 142, new Vector2(1.5f, 3f),0.5f);
        CreateObject(new Vector2(1130, 100), 0, _textures[1], 11, 13, 0.03f, Color.White, 0, 142, new Vector2(3f, 3f),0.3f);


        base.Initialize();
    }
}
