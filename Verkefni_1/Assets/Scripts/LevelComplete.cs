using UnityEngine;
using UnityEngine.SceneManagement;

// Þessi skrifta keyrir þegar spilarinn hefur unnið borðið. Skriftan keyrir næsta borð.
public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel() {
        // Þessi skipan loadar næsta borð samkvæmt indexi núverandi borðs.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
