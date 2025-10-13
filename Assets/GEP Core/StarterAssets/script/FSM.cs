using StarterAssets;
using UnityEngine;

public class FSM : MonoBehaviour
{
    public Play play;
    public Pause pause;
    public Inventory inventory;
    public ThirdPersonController thirdPersonController;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetAllInactive();
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !pause.active)
        {
            SetAllInactive();
            pause.ChangeState();
            thirdPersonController.LockCameraPosition = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && !inventory.active)
        {
            SetAllInactive();
            Inventory();
        }
        else if (Input.GetKeyUp(KeyCode.Q) && inventory.active)
        {
            Resume();
        }
    }

    public void Inventory()
    {
        inventory.ChangeState();
        thirdPersonController.LockCameraPosition = true;
    }
    public void Resume()
    {
        SetAllInactive();
        play.ChangeState();
        thirdPersonController.LockCameraPosition = false;

    }
    public void Settings()
    {
        //settings.changeState()
        pause.setActive(false);
    }
    public void MenueQuit()//ends runtime
    {
        Application.Quit();
    }
    
    public void SetAllInactive()
    {
        play.setActive(false);
        pause.setActive(false);
        inventory.setActive(false);
    }
    //hide everything
    /*
     * settings.setactive(false) repeat this afew times
     * 
     */

    /*
     * settingsmenu.setactive(true)
     */
}
