using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class turtle_script : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public int score;

    public GameObject xiao;
    public float timer;
    public bool watch = false;
    public bool caught = false;
    public bool tap = false;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        xiao.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score: " + score;

        timer += Time.deltaTime;

        if (timer >= 6f && timer <= 8f)
        {
            audioSource.Play();
        }

        if (timer >= 10f && timer <= 12f && watch == false)
        {
            xiao.SetActive(true);
            watch = true;
            timer = 0;
        }

        if (timer >= 2f && timer <= 4f && watch == true)
        {
            xiao.SetActive(false);
            watch = false;
            timer = 0;
        }

        if (watch == true && tap == true)
        {
            caught = true;
        }

        if (caught == true)
        {
            SceneManager.LoadScene("lose");
        }
    }

    private void LateUpdate()
    {
        tap = false;
    }

    public void Tap()
    {
        score++;
        tap = true;
    }
}
