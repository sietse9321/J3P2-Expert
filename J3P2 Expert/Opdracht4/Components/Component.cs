using CSharp_Expert.Opdracht4.BaseClass;

namespace CSharp_Expert.Opdracht4.Components;

public class Component
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
    
    public virtual void Awake() { }
    
    public virtual void Start() { }
}