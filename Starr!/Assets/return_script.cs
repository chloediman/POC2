using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class return_script : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 startposition;
    public bool caught = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(caught == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, startposition, speed * Time.deltaTime);
        }

        if(transform.position.x <= -5)
        {
            caught = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "starr")
        {
            transform.position = new Vector3(transform.position.x - 2, transform.position.y);
            Debug.Log("caught");
            caught = true;
        }
    }
}
