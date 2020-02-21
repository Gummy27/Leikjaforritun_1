using UnityEngine;

// Þessi skrifta verður notuð til að festa spilarann við jörðina sem hreyfir sig (Moving platform)
public class AttachPlayer : MonoBehaviour {

    public GameObject Player; // Fyrst er tekinn inn GameObjectið player svo hægt er að umbreyta honum.

    // Þetta fall er kallað þegar að spilarinn er oná "moving platform".
    private void OnTriggerEnter(Collider other) {
        // Gáð er hvort að hluturinn sem rakst á jörðina sé spilarinn.
        if(other.gameObject == Player) {
            // Spilarinn er gerður að "child" af moving platform svo hann hreyfi sig í samræmi við hann.
            Player.transform.parent = transform;
        }
    }

    // Þetta fall er kallað þegar að spilarinn fer af "moving platform".
    private void OnTriggerExit(Collider other) {
        // Gáð er hvort að hluturinn sem rakst á jörðina sé spilarinn.
        if (other.gameObject == Player) {
            // Spilarinn er gerður að sínum eigin herra þ.e. hann er ekki lengur með neinn "parent".
            Player.transform.parent = null;
        }
    }
}
