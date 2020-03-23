using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Þessa skriftu notar refurinn svo hann ráfar af randomly um heiminn.
public class Wandering : MonoBehaviour
{
    NavMeshAgent agent;

    // Þessar tvær breytur taka inn svæðið sem refurinn getur ferðast um
    float minX = 100, maxX = 400; 
    float minZ = 100, maxZ = 400;

    // Þessi breyta segir til um hve hratt refurinn snýst.
    public float speed = 1.0f;

    Vector3 newPos;
    Transform transform;
    float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        transform = GetComponent<Transform>();
        newPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       // Gáð er hvort að teljarinn er 0 eða að 4 sekúndur hafa liðnar síðan að refurinn breytti um stefnu.
        if (counter == 0 || Time.time - counter > 4)
        {
            // Nýja staðsetningin er valin af handahófi.
            newPos = new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ, maxZ));

            // Agentinn leiðir refnum að staðsetningunni.
            agent.SetDestination(newPos);

            counter = Time.time;
        }
    }
}
