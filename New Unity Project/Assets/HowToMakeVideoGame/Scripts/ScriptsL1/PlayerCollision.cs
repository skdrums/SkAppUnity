using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{


    public PlayerMovement movement;
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();


        }


    }


    private void FixedUpdate()
    {
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }

}
