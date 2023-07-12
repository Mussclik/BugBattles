using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativeForceTest : MonoBehaviour
{
    Rigidbody rigidbodyCom;
    Vector3 startpos;
    public int speed;
    Vector3 localSpaceDir;
    void Start()
    {
        rigidbodyCom = GetComponent<Rigidbody>();
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        UpArrow();
        LeftArrow();
        RightArrow();
        ResetPos();
        ChangeSpeed();
        DrawRays();


    }

    void UpArrow()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbodyCom.AddRelativeForce(Vector3.up * speed);
            Debug.Log("uparrow pressed");
        }
    }

    void LeftArrow()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbodyCom.AddRelativeForce(Vector3.right * speed);
            Debug.Log("leftarrow pressed");
        }
    }

    void RightArrow()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbodyCom.AddRelativeForce(Vector3.forward * speed);
            Debug.Log("rightarrow pressed");
        }
    }

    void ResetPos()
    {
        if (Input.GetKey(KeyCode.X))
        {
            transform.position = startpos;
        }
 
    }

    void ChangeSpeed()
    {
        if (Input.GetKey(KeyCode.J))
        {
            speed++;
            Debug.Log("Current speed is: " + speed);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            speed--;
            Debug.Log("Current speed is: " + speed);
        }
    }

    void DrawRays()
    {
        Debug.DrawRay(transform.position, Vector3.up, Color.green);
        Debug.DrawRay(transform.position, Vector3.right, Color.red);
        Debug.DrawRay(transform.position, Vector3.forward, Color.blue);
    }
}
