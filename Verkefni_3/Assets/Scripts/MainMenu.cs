using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Þessi skrifta er notuð af hnöppunum í valmyndunum.
public class MainMenu : MonoBehaviour
{
    // Þetta fall loadar næstu senu.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Þetta fall loadar main senunni.
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Þetta fall hættir leiknum.
    public void QuitGame()
    {
        Application.Quit();
    }
}
