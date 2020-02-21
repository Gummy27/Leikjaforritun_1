using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public Transform player;

    public float forwardForce = 4000f;  // Hve hratt spilarinn færir sig áfram.
    public float sidewaysForce = 1000f; // Hve hratt spilarinn færir sig til hliðar.
    public float jumpForce = 1000f;     // Hve hratt spilarinn hoppar.
    private bool OnPlatform = true;     // Segir til um hvort að spilarinn sé á platform.

    // Þetta fall er kallað nokkrum sinnum á hverji sekúndu í samræmi við vinnsluhraða tölvunnar.
    void FixedUpdate(){
        // Gáð er hvort að spilarinn vilji færa sig til hægri.
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        // Gáð er hvort að spilarinn vilji færa sig til vinstri.
        if (Input.GetKey("a") || Input.GetKey("left")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        // Gáð er hvort að spilarinn vilju færa sig áfram.
        if (Input.GetKey("w") || Input.GetKey("up")) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        // Gáð er hvort að spilarinn vilju færa sig til baka.
        if (Input.GetKey("s") || Input.GetKey("down")) {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        
        // Gáð er hvort að spilarinn vilji hoppa og hvort að hann sé á jörðinni svo hann geti ekki hoppað í loftinu.
        if (Input.GetKey("space") && OnPlatform) {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }

        // Gáð er hvort að spilarinnn hafi dottið niður.
        if (player.position.y < 0) {
            // Ef svo er þá er borðið endurræst.
            Invoke("Restart", 1);
        }
    } 

    // Þetta fall er einungis notað til að endurræsa borðið.
    void Restart() { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Þetta fall er kallað þegar spilarinn fer á jörðina.
    private void OnTriggerEnter(Collider other) {
        // Gáð er hvort að hluturinn sem að spilarinn hafi rekist á sé jörðinn.
        if (other.gameObject.tag == "Platform") {
            // Ef svo er þá er OnPlatform sett í true svo spilarinn getur hoppað.
            OnPlatform = true;
        }
    }

    // Þetta fall er kallað þegar spilarinn fer af jörðinni.
    private void OnTriggerExit(Collider other) {
        // Gáð er hvort að hluturinn sem spilarinn rakst á sé jörðinn.
        if (other.gameObject.tag == "Platform") {
            // Ef svo er þá er OnPlatform sett i false svo að spilarinn geti ekki hoppað. 
            OnPlatform = false;
        }
    }

}
