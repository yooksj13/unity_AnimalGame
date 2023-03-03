using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public void OnClickRestart()
    {
        PlayerController.life = 3;
        SceneManager.LoadScene (0);
    }

    public void OnClickExit()
    {
        Application.Quit ();
    }
}
