using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsText : MonoBehaviour
{
    public float speed;
    public GameObject posToSteal;
    public Vector3 startpos;
    public GameObject credittext;

    void Start()
    {
        startpos = credittext.transform.localPosition;
    }
    void OnDisable()
    {
        credittext.transform.localPosition = startpos;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        credittext.transform.localPosition = startpos;
        Debug.Log("Something Exited");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something Entered");
    }

    void Update()
    {
        float newY = 1 * speed * Time.deltaTime;
        Vector3 newpos = new Vector3(credittext.transform.position.x, credittext.transform.position.y + newY, credittext.transform.position.z);
        credittext.transform.position = newpos;
    }
}
