using UnityEngine;
using UnityEngine.XR;

public abstract class GameState : MonoBehaviour
{

    public bool active = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void ChangeState();

    public void setActive(bool is_active)
    {
        active = is_active; 
    }

}
