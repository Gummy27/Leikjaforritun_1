using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Þessi skrifta verður notuð til að beina skrímslinu að spilaranum.
public class AgentScript : MonoBehaviour
{
    public Transform target; // Þessi breyta mun taka inn spilarann sem skrímslið á að fylgja

    Transform transform; // Þessi breyta tekur seinna inn transform component hjá skrímslinu
    NavMeshAgent agent;  // Þessi breyta tekur seinna inn agent component hjá skrímslinu.

    // Í start fallinu munu nokkrar breytur fá gildin sín.
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        // Gáð er hvort að skrímslið sé komið nógu nálægt spilaranum til þess að ráðast á hann
        if (Vector3.Distance(target.position, transform.position) < 2)
        {
            // Skrímslinu er sagt að stoppa.
            agent.SetDestination(transform.position);
        }
        else
        {   
            // Skrímslinu er beint á staðsetningu spilarans.
            agent.SetDestination(target.position);
        }
    }
}
