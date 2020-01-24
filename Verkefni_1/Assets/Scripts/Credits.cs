using UnityEngine;

// Þetta skrift verður notað til að exita leikinn þegar spilarinn ýtir á quit takkann
public class Credits : MonoBehaviour {
    public void quit() {
        // Þessi skipun lokar leiknum.
        Application.Quit();
    }
}
