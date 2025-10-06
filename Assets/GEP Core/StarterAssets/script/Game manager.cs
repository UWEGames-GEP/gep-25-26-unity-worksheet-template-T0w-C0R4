using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public enum GameStates
    {
        Play,
        Pause,
    };
    public GameStates state;
    private bool has_changed_state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        has_changed_state = false;
        state = GameStates.Play;
    }

    // Update is called once per frame
    void Update()
    {

        switch (state)
        {
            case GameStates.Play:

                if (Input.GetKeyUp(KeyCode.Return))
                {
                    Debug.Log("Switching to state Pause");
                    state = GameStates.Pause;
                    has_changed_state = true;
                }

            break;

            case GameStates.Pause:

               if (Input.GetKeyUp(KeyCode.Return))
               {
                   Debug.Log("Switching to state Play");
                   state = GameStates.Play;
                   has_changed_state = true;
               }

            break;
        }

    }

    private void LateUpdate()
    {
        switch (state)
        {
            case GameStates.Play:
                Time.timeScale = 1.0f; 
            break;

            case GameStates.Pause:
                Time.timeScale = 0.0f; 
            break;
        }
    }
}
