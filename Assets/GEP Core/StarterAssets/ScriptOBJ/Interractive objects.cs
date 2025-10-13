using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Interractiveobjects", menuName = "Scriptable Objects/Interractiveobjects")]
public class Interractiveobjects : ScriptableObject
{
    public string _id;
    public float _localSize;
    public GameObject Prefab;
    public Image jpg_image64x64_;
    
    //interract
}
