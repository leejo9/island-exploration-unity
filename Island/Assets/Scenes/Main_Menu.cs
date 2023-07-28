using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Main_Menu : MonoBehaviour
{
    public Button start_button, Instr_Button;
    // Start is called before the first frame   update
    void Start()
    {
        Button start = start_button.GetComponent<Button>();
        Button instr = Instr_Button.GetComponent<Button>();

    }

    // Update is called once per frame
    public void game_start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
    public void game_intro()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instructions");
    }

}
