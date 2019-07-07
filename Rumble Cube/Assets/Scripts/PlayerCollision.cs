using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        // name of thing we just hit
        // Debug.Log(collisionInfo.collider.name);

        //for path obstacles.
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("'Bad Luck' Better luck next time");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
