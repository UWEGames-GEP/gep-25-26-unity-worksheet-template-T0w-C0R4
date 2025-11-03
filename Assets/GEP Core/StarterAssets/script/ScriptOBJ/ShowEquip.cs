using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ShowEquip : MonoBehaviour
{
    public List<GameObject> meshes;
    //equipped object from inventory
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // current equip is null so empty mesh

    }

    // Update is called once per frame
    void Update()
    {
        //keep the equipped mesh transform to the same as the bone
    }

    public void ChangeMesh(string new_mesh)
    { 

    }
}
