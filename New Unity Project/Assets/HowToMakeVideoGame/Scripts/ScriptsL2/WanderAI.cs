using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAI : MonoBehaviour {

    public float moveSpeed = 1.5f;

    public float rotSpeed = 30f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;

    private bool isWalking = false;
    // Use this for initialization
    void Start () {
        transform.Rotate(transform.up * Time.deltaTime * rotSpeed * Random.Range(1, 6));
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (isWandering == false)
        {
            StartCoroutine(Wander());
        }
        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime*rotSpeed * Random.Range(1, 3));
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(-transform.up * Time.deltaTime * rotSpeed*Random.Range(1,3));
        }
        if (isWalking == true)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime*Random.Range(1,5);
        }

    }

    IEnumerator Wander()
    {
        int rotTime=Random.Range(1, 3);
        int rotateWait = Random.Range(1, 4);
        int rotateLorR = Random.Range(1, 2);
        int walkWait = Random.Range(1, 4);
        int walkTime = Random.Range(1, 5);

        isWandering = true;
        yield return new WaitForSeconds(rotateWait);
        if (rotateLorR == 1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }
        else
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }
        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
       
        isWandering = false;


    }


}
