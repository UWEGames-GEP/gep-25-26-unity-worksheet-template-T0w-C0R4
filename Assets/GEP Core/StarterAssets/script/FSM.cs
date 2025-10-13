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

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !pause.active)
        {
            pause.ChangeState();
            play.setActive(false);
            thirdPersonController.LockCameraPosition = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && !inventory.active)
        {
            Inventory();
        }
    }

    public void Inventory()
    {
        inventory.ChangeState();
        play.setActive(false);
        thirdPersonController.LockCameraPosition = true;
    }
    public void Resume()
    {
        play.ChangeState();
        pause.setActive(false);
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
    //hide everything
    /*
     * settings.setactive(false) repeat this afew times
     * 
     */

    /*
     * settingsmenu.setactive(true)
     */
}
