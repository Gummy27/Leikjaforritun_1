using UnityEngine;

// Þetta skrift verður notað til að láta myndavélina fylgja spilaranum (kassanum).
public class FollowPlayer : MonoBehaviour {

    public Transform player; // Þessi breyta tekur inn x, y og z staðsetningu spilarans.
    public Vector3 offset;   // Þessi breyta tekur 3 breytur sem ákveða hve langt frá spilaranum myndavélinn á að vera í x, y og z ásunum.

    // "Update" er kallað einu sinni á hverju "frame".
    void Update() {
        // Staðsetning myndavélarinnar er reiknuð út frá x, y, z staðsetningu spilarans og x, y, z gildi offset sem færir myndavélina aðeins til baka.
        transform.position = player.position + offset;
    }
}
