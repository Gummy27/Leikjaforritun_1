using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {

    public Text countText;              // Breytan counText mun innihalda Text Game objectið svo hægt sé að uppfæra stiginn.
    private int count;                  // Int breytan count verður notuð til að geyma stiginn.
    public int winCondition;            // Int breytan wincondition mun geyma fjölda stiga sem þarf að ná til að vinna borðið.
    public GameObject completeLevelUI;  // Breytan completeLevelUi er notuð til að kveikja á animation þegar spilarinn vinnur borðið.

    // Þetta fall verður kallað aðeins einu sinni þegar að borðið byrjar og er notað til að initializa breytur.
    private void Start() {
        count = 0;      // Count er að sjálfsögðu fyrst sett í 0 þar sem spilarinn hefur ekki náð neinum stigum.
        SetCountText(); // Stigataflan er uppfærð.
    }

    // Þetta fall er kallað þegar að spilarinn rekst á eitthvað.
    private void OnTriggerEnter(Collider other) {
        // Gáð er hvort að hluturinn sem að spilarinn rakst á er collectible(pickup).
        if(other.gameObject.CompareTag("Pickup")) {
            other.gameObject.SetActive(false); // Collectible er sett inactive.
            count += 1;                        // Spilarinn fær eitt stig.
            SetCountText();                    // Stigataflan er uppfærð.
        }
    }

    // Þetta fall er notað til að uppfæra stigatöfluna.
    void SetCountText() {
        // Textinn á stigatöflunni er skrifuð og sett upp á skjá.
        countText.text = "Stig: " + count.ToString() + " af " + winCondition;

        // Gáð er hvort að spilarinn sé með nógu mikið af stigum til þess að vinna.
        if(winCondition == count) {
            completeLevelUI.SetActive(true); // CompleteLevelUi aninmation er virkjað.
            Invoke("LevelComplete", 3);      // Forritið keyrir levelcomplete fallið eftir 3 sekúndur.
        }
    }

    // Þetta fall er notað til að fara í næsta borð.
    void LevelComplete() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
