using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_script : MonoBehaviour
{
    Vector3 mouseposition;
    public float movespeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        position = Vector2.Lerp(transform.position, mouseposition, movespeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}
