using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void Button_Resume()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            GetComponent<PauseMenu>().pauseMenuUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Button_Restart()
    {
        Application.LoadLevel("SampleScene");
        Time.timeScale = 1;
    }

    public void Button_Quit()
    {
        Application.Quit();
    }
}
