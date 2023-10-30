using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction vector from this object to the player
        Vector3 directionToPlayer = player.position - transform.position;

        // Calculate the rotation to look at the player (use Quaternion.LookRotation)
        Quaternion lookRotation = Quaternion.LookRotation(directionToPlayer);

        // Apply the rotation to make the object face the player
        transform.rotation = lookRotation;
    }
}
