using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public NavMeshAgent enemy;

    public Transform Player;

    public LayerMask whatIsGround, whatIsPlayer;

    private void Update()
    {
        enemy.SetDestination(Player.position);
    }


}
