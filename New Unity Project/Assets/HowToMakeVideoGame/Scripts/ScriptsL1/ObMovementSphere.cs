using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObMovementSphere : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 2000f;
    



	// Use this for initialization
	void Start () {
        int r = Random.Range(1, 3);
        if (r==1)
        rb.AddForce(forwardforce,0, 0);
        else
            rb.AddForce(-forwardforce, 0,0);
    }
	
	
}
