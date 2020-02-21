using UnityEngine.SceneManagement;
using UnityEngine;

// Þessi skrifta er notuð til að loada næsta borð.
// Hún er keyrð þegar spilarinn klikkar á takkann í main menu
public class StartGame : MonoBehaviour {
    public void LoadLevel() {
        // Þessi skipan loadar næsta borð samkvæmt indexi núverandi borðs.
        Debug.Log("Start Game!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

