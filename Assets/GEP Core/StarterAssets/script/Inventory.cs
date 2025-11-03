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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            items.Add("0");
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

    public void Remove() 
    {
        for (int i = 0; i < 3; i++)
        {
            items[i] = items[i+1];
        }
        
    }
    public void Add(string item) 
    {
        if (items[3] != "0")
        {
            Remove();
            items[3] = item;
        }
        else 
        {
            for (int i = 0; i < 4; i++)
            {
                if (items[i] == "0")
                {
                    items[i] = item;
                    inventory_text[i].changeText(GetItem(i));
                    break;
                }
            }
        }
    }

    public void EquipItem(int inventry_no)
    {
        equiped = items[inventry_no];
        Debug.Log($"equipped items is {items[inventry_no]}");

        FSM.Resume();
    }

    public string GetItem(int inventry_no) 
    {
        return items[inventry_no]; 
    }
}
