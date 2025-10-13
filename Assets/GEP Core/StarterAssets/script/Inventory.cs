using UnityEngine;
using System.Collections.Generic;
public class Inventory : GameState
{
    public List<string> items = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!active)
        {
            this.GetComponent<Canvas>().enabled = active;
        }
    }

    public override void ChangeState()
    {
        Time.timeScale = 0.1f;
        setActive(true);
        this.GetComponent<Canvas>().enabled = active;
        Cursor.visible = true;
    }

    public void Remove(string item) 
    {
        items.Remove(item);
    }
    public void Add(string item) 
    {
        items.Add(item);
    }
}
