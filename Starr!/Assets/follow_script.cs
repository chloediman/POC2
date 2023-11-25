using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class follow_script : MonoBehaviour
{
    Vector3 mouseposition;
    public float movespeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    public int score;
    public TextMeshProUGUI scoretext;
    public bool caught = false;

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

        if(caught)
        {
            score += 1;
            caught = false;
        }

        scoretext.text = "Score: " + score;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "laser")
        {
            caught = true;
        }
    }
}
