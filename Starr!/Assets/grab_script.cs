using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab_script : MonoBehaviour
{
    public bool grabbed;
    RaycastHit2D hit;
    public float distance = 2f;
    public Transform holdpoint;
    public float throwforce = 1;
    public float xvelocity = 5.5f;
    public float yvelocity = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(!grabbed)
            {
                Physics2D.queriesStartInColliders = false;
                hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x);

                if(hit.collider != null)
                {
                    grabbed = true;
                }
            }

            else
            {
                grabbed = false;

                if(hit.collider.gameObject.GetComponent<Rigidbody2D>()!= null)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xvelocity, yvelocity) * throwforce;
                }
            }
        }

        if(grabbed)
        {
            hit.collider.gameObject.transform.position = holdpoint.position;
        }    
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawLine(transform.position + Vector3.left * transform.localScale.x * distance, transform.position + Vector3.right * transform.localScale.x * distance);
    }
}
