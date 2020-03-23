using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;      // Tekið er inn hve mörg líf spilarinn á að hafa.
    public Text text;       // Textinn sem sýnir lífinn er tekinn inn
    public Transform enemy; // Skrímslið sem á að elta spilarann er tekinn inn.
    public AudioClip clip;  // Hljóðið sem spilar þegar að spilarinn er meiddur er tekinn inn.

    float timer = 0;        // Breytan timer er búinn til og fær gildið 0.0

    private Transform player;          // Spilarinn seinna tekinn inn í þessa breytu.          
    private AudioSource m_AudioSource; // Hátalarinn er seinna tekinn inn í þessa breytu.

    void Start()
    {
        player = GetComponent<Transform>();
        text.text = "Lif: " + health.ToString();
        m_AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Gáð er hvort að spilarinn sé búinn að tapa leiknum.
        if (health <= 0)
        {
            // Músinn er gerð sýnileg og hreyfileg svo hægt er að ýta á valmyndina.
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            // Næsta sena er loaduð sem er menu.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        // Gáð er hvort að skrímslið sé nógu nálægt til þess að skaða spilaran.
        // Einnig er gáð hvort að skrímslið sé nýbúið að meiða spilarann.
        if(Vector3.Distance(player.position, enemy.position) < 3 && Time.time - timer > 3)
        {
            // Spilarinn missir eitt líf.
            health -= 1;
            timer = Time.time;

            // Textinn sem sýnir lífinn er uppfærður.
            text.text = "Lif: " + health.ToString();

            // Hljóðið er spilað.
            m_AudioSource.clip = clip;
            m_AudioSource.Play();
        } 
    }

    // Þetta fall keyrir þegar spilari hefur rekist á trigger.
    private void OnTriggerEnter(Collider other)
    {
        // Gáð er hvort að hluturinn sem að spilarinn rakst á er collectible(pickup).
        if (other.gameObject.CompareTag("Pickup"))
        {
            // Pickupið er eytt
            other.gameObject.SetActive(false); 

            // Spilarinn fær eitt hjarta.
            health += 1;                       

            // Textinn sem sýnir lífinn er uppfærður.
            text.text = "Lif: " + health.ToString();
        }
    }
}
