using UnityEngine;
using System.Collections.Generic;
using System;
using TMPro;
public class Inventory : GameState
{
    public FSM FSM;
    public string equiped;
    [SerializeField] private List<string> items = new List<string>();
    public List<changetext> inventory_text;
    public List<GameObject> Items;
    public GameObject player_ref;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            items.Add("0");
            Items.Add(null);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!active)
        {
            this.GetComponent<Canvas>().enabled = active; //active is the current state
        }


    }

    public override void ChangeState()
    {
        Time.timeScale = 0.1f;
        setActive(true);
        this.GetComponent<Canvas>().enabled = active;
         Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Remove(int i) 
    {

            items[i] = "0";
        Items[i] = null;
        inventory_text[i].changeText($"item{i}");


    }
    public void Add(string item, GameObject added_item) 
    {

            for (int i = 0; i < 4; i++)
            {
                if (items[i] == "0")
                {
                    items[i] = item;
                    Items[i] = added_item;
                    inventory_text[i].changeText(GetItem(i));
                    break;
                }
            }
    }

    public void droppItem(int inventry_no)
    {
        Vector3 vector3 = new Vector3(player_ref.transform.position.x+1, player_ref.transform.position.y, player_ref.transform.position.z);
        equiped = items[inventry_no];
        Debug.Log($"drop items is {items[inventry_no]}");
        //create instance of object 4 meters away from character
        Items[inventry_no].gameObject.SetActive( true );
        Items[inventry_no].gameObject.transform.position = vector3;

        Remove(inventry_no);


        FSM.Resume();
    }

    public string GetItem(int inventry_no) 
    {
        return items[inventry_no]; 
    }
}
