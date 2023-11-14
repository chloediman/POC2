using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pet_script : MonoBehaviour
{
    public TextMeshProUGUI pettext;
    public int pets;

    // Start is called before the first frame update
    void Start()
    {
        pets = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pettext.text = "You have pet Starr " + pets + " times";
    }

    public void Clicker()
    {
        pets++;
    }
}
