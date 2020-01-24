using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb; // Breyta rb tekur inn RigidBody "component" frá spilara svo hægt sé að hreyfa spilarann.
    
    public float forwardForce = 4000f; // Breytan forwardForce tekur inn hve hratt spilarinn á að fara áfram.
    public float sidewaysForce = 1000; // Breytan sidewaysForce tekur inn hve hratt spilarinn á að fara til hægri og vinstri.

    // Fallið fixedUpdate er kallað einu sinni á "frame" í samræmi við vinnsluhraða tölvunar. Þetta fall verður notað til að hreyfa spilarann.
    void FixedUpdate() {
        // deltaTime er notað í stað frames til að ákveða hve langt spilarinn á að fara svo að spilarinn fari ekki hraðar á betri tölvum og hægar á verri tölvum.

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Spilarinn er færður áfram.

        // Gáð er hvort að spilarinn vill færa kubbinn til hægri.
        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0); // Spilarinn er færður til hægri
        }
        
        // Gáð er hvort að spilarinn vill færa kubbinn til vinstri.
        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0); // Spilarinn er færður til vinstri.
        }

        // Gáð er hvort að spilarinn er búinn að detta af "platforminu".
        if(rb.position.y < -1f) {
            FindObjectOfType<GameManager>().Endgame(); // Borðið er endurræst.
        }
    }
}
