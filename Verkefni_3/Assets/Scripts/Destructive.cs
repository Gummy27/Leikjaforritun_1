using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Þessi skrifta mun sjá um eyðileggingu kassa.
public class Destructive : MonoBehaviour
{
    public GameObject destroyedVersion; // Tekið er inn hinn kasann sem er þegar brotinn
    public Transform player;            // Spilarinn er tekinn inn.

    private void Update()
    {
        // Gáð er hvort að spilarinn sé kominn of nálægt.
        if(Vector3.Distance(player.position, transform.position) < 2)
        {
            // Brotni kassinn er komið inn á sama stað og heili kassinn.
            Instantiate(destroyedVersion, transform.position, transform.rotation);

            // Heili kasinn er eyðilagður.
            Destroy(gameObject);
        }
    }
}
