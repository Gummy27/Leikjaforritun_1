using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Þessi skrifta er notuð til að snúa pick up-unum.
public class Rotator : MonoBehaviour {
    void Update() {
        // Þessi aðgerð hreyfir kubbinn um x, y og z ásinn í samræmi við hraða tölvunnar.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
