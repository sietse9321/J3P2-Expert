namespace CSharp_Expert.Opdracht4.BaseClass;

[System.Flags]
public enum PrefabComponent
{
    Rotater = 1,        //[0001]
    Bouncer = 2,        //[0010]
    Scaler = 4,         //[0100]
    ColorShifter = 8    //[1000]
}