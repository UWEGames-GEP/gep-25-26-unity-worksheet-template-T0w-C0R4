using UnityEngine;

public class FSM : MonoBehaviour
{
    public Play play;
    public Pause pause;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pause.ChangeState();
            play.setActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void Resume()
    {
        play.ChangeState();
        pause.setActive(false);

        Cursor.lockState= CursorLockMode.Locked; 
        Cursor.visible = false;
    }
    public void Settings()
    {
        //settings.changeState()
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
