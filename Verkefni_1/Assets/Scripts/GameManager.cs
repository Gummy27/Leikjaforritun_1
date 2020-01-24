using UnityEngine;
using UnityEngine.SceneManagement;

// Game manager skriftan mun hafa ýmis föll sem annaðhvort endar eða endurræsir borðið.
public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;         // Breytan gameHasEnded er bool breyta sem verður notuð til að gá hvort að leikurinn hafi klárast.
    public float restartDelay = 1f;    // Restart delay er breyta sem ákveður hve langan tíma á að vera á milli þess að spilarinn tapar og borðið endurræsist.
    public GameObject completeLevelUI; // completeLevelUI er breyta sem tekur inn levelcomplete canvas svo hægt sé að sýna skilaboðinn "Borð lokið" þegar borðið klárast.

    // Þetta fall mun byrja "animation" á canvas hlutnum levelcomplete svo leikarinn fær skilaboðinn "Borð lokið" þegar hann hefur unnið borðiðþ
    public void CompleteLevel() {
        completeLevelUI.SetActive(true); // Animation á levelcomplete canvas er byrjað.
    }

    // Þetta fall mun endurræsa borðið ef að spilarinn hefur tapað.
    public void Endgame() {
        // Fyrst er gáð hvort að gameHasEnded breytan sé false. Ef svo er þá er hún breytt í true.
        if (!gameHasEnded) {
            gameHasEnded = true;
            // Þessi skipun endurræsir borðið með ákveðnu "delay".
            Invoke("Restart", restartDelay);
        }
    }

    // Þetta fall endurræsir borðið með því að "loada" það aftur.
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
