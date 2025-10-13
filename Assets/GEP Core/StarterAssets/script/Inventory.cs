using UnityEngine;
using System.Collections.Generic;
public class Inventory : GameState
{
    public string equiped;
    public string[] items = new string[4];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        if (items[4] != null)
        {
            Remove();
            items[4] = item;
        }
        else 
        {
            for (int i = 0; i < 4; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    break;
                }
            }
        }
    }
}
