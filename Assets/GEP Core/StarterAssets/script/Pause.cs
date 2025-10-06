using StarterAssets;
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
        setActive(true);
        this.GetComponent<Canvas>().enabled = active;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }
}
