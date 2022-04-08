using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Переключение на следующую сцену в очереди
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Загрузка сцены по названию или индексу
        //SceneManager.LoadScene("Level01");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
