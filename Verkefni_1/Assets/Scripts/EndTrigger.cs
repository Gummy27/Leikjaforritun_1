using UnityEngine;

// Þetta skrif er notað til að enda borðið þegar spilarinn er búinn að vinna borðið.
public class EndTrigger : MonoBehaviour {

    // Þessi breyta mun taka inn Game managerinn svo hægt sé að láta hann vita að borðið er búið.
    public GameManager gameManager;

    void OnTriggerEnter () {
        // Game manager lýkur borðinu og færir í næsta.
        gameManager.CompleteLevel();
    }
}