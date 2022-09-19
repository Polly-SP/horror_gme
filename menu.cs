using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void StartGame(string game)
    {
        SceneManager.LoadScene(game); // в скобках, переход на сцену по индексу (переход на +1)
    }

    public void ExitGame()
    {
        Debug.Log("я вышел");
        Application.Quit();
    }
}