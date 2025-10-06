using UnityEngine;

public class Pause : GameState
{
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
        Time.timeScale = 0.0f;
        this.GetComponent<Canvas>().enabled = active;
        setActive(true);
       
    }
}
