using System;
using Patterns;
using UnityEngine;

public static class StaticCalculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static float Add(float a, float b)
    {
        return a + b;
    }
}

public abstract class AbstractCalculator<TResult, TArg>
{
    public abstract TResult Add(TArg a, TArg b);
}

public class IntCalculator : AbstractCalculator<int, int>
{
    public override int Add(int a, int b)
    {
        return a + b;
    }
}

public class FloatCalculator : AbstractCalculator<float, float>
{
    public override float Add(float a, float b)
    {
        return a + b;
    }
}

public static class Writer
{
    public static void Print<T>(T value)
    {
        Debug.Log(value);
    }
}

public class Calculator : MonoBehaviour
{
    private void Start()
    {
        AbstractCalculator<string, string> c;

        Writer.Print("1234");

        // Debug.Log(c.Add(40.0f, 2.0f));
    }
}