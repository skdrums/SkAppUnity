
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public GameObject MovementUI;
   

    public float forwardForce = 200000f;
    public float sidewayForce = 500f;

    private void Start()
    {
        rb.AddForce(0, 0, forwardForce );
    }

    bool pushRight = false;
    bool pushLeft = false;
    public void PushDownRight()
    {
        pushRight = true;
    }

    public void PushUpRight()
    {
        pushRight = false;
    }

    public void PushDownLeft()
    {
        pushLeft = true;
    }

    public void PushUpLeft()
    {
        pushLeft = false;
    }

    // Update is called once per frame
    void FixedUpdate () {

        if (pushRight)
        {
            MoveRight();
        }

        if (pushLeft)
        {
            MoveLeft();
        }

        if (Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")||Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0,sidewayForce * Time.deltaTime, 0);
        }
           

    }
    
    public void MoveRight()
    {
        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
    }

    public void MoveLeft()
    {
        rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
    }


}

