using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem.Processors;
using Unity.VisualScripting;

public class Itemscript : MonoBehaviour
{
    public FSM FSM;
    public CharacterController characterController;
    public Collider equipped_collider;
    public MeshRenderer equipped_mesh;
    private Vector3 collected_pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = GetComponent<GameObject>().name;
        equipped_collider = GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.detectCollisions == true)
        {
            Debug.Log("collided");
            //FSM.inventory.Add(name,new Item());
            equipped_collider.enabled = false;
            equipped_mesh.enabled = false;
            
        }
    }
}
