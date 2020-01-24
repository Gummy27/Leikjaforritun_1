using UnityEngine;
using UnityEngine.UI;

// Þessi skrifta er notuð til að telja stig.
public class Score : MonoBehaviour {
    public Transform player; // Breytan player tekur inn staðsetningu spilarans svo hægt sé að reikna út hve langt hann hefur farið.
    public Text scoreText;   // Breytan scoreText tekur inn textann sem score canvas sínir svo hægt sé að uppfæra sigatöfluna.

    // Þetta fall er kallað einu sinni á hverju "frame" og er notuð til að reikna stig spilarans.
    void Update() {
        // Þessi skipun tekur staðsetningu spilarans á z ás og færir það í scoretext svo stigataflan er uppfærð.
        scoreText.text = player.position.z.ToString("0");  
    }
}
