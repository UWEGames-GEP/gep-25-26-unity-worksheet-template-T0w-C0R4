using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Interractiveobjects", menuName = "Scriptable Objects/Interractiveobjects")]
public class Interractiveobjects : ScriptableObject
{
    public string prefab_name;
    public int set_layer = 3;
    public int numberOfPrefabsToCreate;
    public Vector3[] SpawnPoint;
}
