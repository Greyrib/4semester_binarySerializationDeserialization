using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[Serializable]

// Specifies that we want Sequential packing of our data, which isn't a default,
// and to apply no padding to our struct & thus takes up bytes specified, i.e. an int takes 4 bytes
[StructLayout (LayoutKind.Sequential, Pack = 1)] 
public struct MyData // Note no MonoBehaviour inheritance
{
    public Vector3 position;
    // Marshaler needs to know size of strings
    // Ideally try to minimize size of struct for compression
    [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 128)]
    public string name;
    public int health;
    public int shield;
    public override string ToString ()
    {
        return $"{name}, health: {health}, shield: {shield} @ { position}";
    }
}
