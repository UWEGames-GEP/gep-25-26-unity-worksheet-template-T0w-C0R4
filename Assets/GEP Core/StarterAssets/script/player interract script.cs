using System;
using Unity.VisualScripting;
using UnityEngine;

public class playerinterractscript : MonoBehaviour
{
    public Inventory inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit != null && hit.gameObject.layer == 3)
        {
            string item_name = hit.gameObject.name;

            inventory.Add(item_name);
            hit.gameObject.SetActive(false);
            
        }
        
    }
}
