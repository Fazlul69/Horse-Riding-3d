using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Events : MonoBehaviour
{
    public void GamePlay()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void GameMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
