using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Þessi skrifta verður notuð til að endurræsa leikinn.
public class RestartGame : MonoBehaviour {
    public void PlayAgain() {
        // Þessi skipan loadar næsta borð samkvæmt indexi núverandi borðs.
        Debug.Log("Start Game!");
        SceneManager.LoadScene(1);
    }
}
