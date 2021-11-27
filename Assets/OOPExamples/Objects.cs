using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractGreeter
{
    protected string _punctuationMark = "?";

    public string Greet(string name)
    {
        return Greet(name, _punctuationMark);
    }

    public abstract string Greet(string name, string punctuationMark);
}

public class Greeter : AbstractGreeter
{
    public Greeter()
    {
        _punctuationMark = "!";
    }

    public Greeter(string punctuationMark)
    {
        _punctuationMark = punctuationMark;
    }

    public override string Greet(string name, string punctuationMark)
    {
        return "Hello, " + name + punctuationMark;
    }
}

public class RussianGreeter : AbstractGreeter
{
    public override string Greet(string name, string punctuationMark)
    {
        return "Привет, " + name + punctuationMark;
    }
}



public class Objects : MonoBehaviour
{
    private void Start()
    {
        // AbstractGreeter g1 = new RussianGreeter();
        // AbstractGreeter g2 = new Greeter(".");
        //
        // Debug.Log(g1.Greet("World", "!"));
        // Debug.Log(g2.Greet("World"));
    }
}