using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerptest : MonoBehaviour
{

    public Transform[] positions;
    Vector3 desiredposition;
    public float speed;
    int counter;

    private void Start()
    {
        desiredposition = positions[0].position;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, desiredposition, Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (counter == 0)
            {
                desiredposition = positions[counter].position;
                counter = 1;
            }
            else
            {
                desiredposition = positions[counter].position;
                counter = 0;
            }
        }
    }
}
