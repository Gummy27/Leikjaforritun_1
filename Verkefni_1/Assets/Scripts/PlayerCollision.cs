using UnityEngine;

// Þessi skriftar nemur collision á milli spilara og hindrunar og endurræsir borðið.
public class PlayerCollision : MonoBehaviour{

    public PlayerMovement movement; // Breytan movement tekur inn skriftuna player movement svo hægt sé að stoppa spilarann.

    // Þetta fall gáir hvort að árekstur hefur orðið á milli spilara og hindranar. 
    void OnCollisionEnter(Collision collisionInfo){
        // Þessi if setning gáir hvort að hluturinn sem spilarinn hefur rekist á er hindrun en ekki jörðinn.
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;                   // Spilarinn er stoppaðurþ
            FindObjectOfType<GameManager>().Endgame();  // Game manager er fundinn svo hægt sé að endurræsa borðið. 
        }
    }
}
