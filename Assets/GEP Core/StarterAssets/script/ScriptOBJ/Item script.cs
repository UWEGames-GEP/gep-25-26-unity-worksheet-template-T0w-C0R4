using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem.Processors;
using Unity.VisualScripting;

public class Itemscript : MonoBehaviour
{
    public FSM FSM;
    public CharacterController characterController;
    public SphereCollider equipped_collider;
    public MeshRenderer equipped_mesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.detectCollisions == true)
        {
            FSM.inventory.Add("sphere");
            equipped_collider.IsDestroyed();
            equipped_mesh.IsDestroyed();
        }
    }
}
