using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Interractiveobjects", menuName = "Scriptable Objects/Interractiveobjects")]
public class Interractiveobjects<Sphere, Cube, Cone> : ScriptableObject
{
    string _id;
    float _localSize;
    GameObject Prefab;
    Image jpg_image64x64_;
    //interract

    //look at this https://unity.com/how-to/separate-game-data-logic-scriptable-objects
}
