using UnityEngine;

public class Play : GameState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ChangeState()
    {
        Time.timeScale = 1.0f;
        setActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Camera.main.enabled = true;
    }
}
