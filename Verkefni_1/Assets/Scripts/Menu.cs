using UnityEngine;
using UnityEngine.SceneManagement;

// Þessi skrifta loadar næsta borð þegar spilarinn er búinn að ýta á byrja.
public class Menu : MonoBehaviour {
    public void StartGame() {
        // Þessi skipan loadar næsta borð samkvæmt indexi núverandi borðs.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
