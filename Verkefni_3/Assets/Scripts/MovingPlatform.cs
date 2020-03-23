using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Þessi skrifta færir moving platform.
public class MovingPlatform : MonoBehaviour
{
    public Transform platform;
    Vector3 newPos;

    void FixedUpdate()
    {
        // Breytan newPos tekur inn staðsetningu platformsins.
        newPos = platform.position;

        // Y staðsetning newPos er breytt í samræmi við sinus fallið af Time.time sem er frá -1 - 1;
        newPos.y = 41+41*Mathf.Sin(Time.time/4);

        // Platformið fær á sig nýju staðsetninguna.
        platform.position = newPos;
    }
}
