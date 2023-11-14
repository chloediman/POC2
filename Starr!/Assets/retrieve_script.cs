using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retrieve_script : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 targetposition;
    public Vector3 startposition;
    public bool caught = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(caught == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetposition, speed * Time.deltaTime);
        }

        else if(caught == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, startposition, speed * Time.deltaTime);
        }

        if(transform.position.x <= -4.5)
        {
            caught = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "mouse")
        {
            transform.position = Vector3.MoveTowards(transform.position, startposition, speed * Time.deltaTime);
            caught = true;
        }
    }
}
