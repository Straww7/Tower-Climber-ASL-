using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class platform : MonoBehaviour
{
    //attiva le piattaforme al passaggio del player

    public Text score;
    int temp;
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<BoxCollider2D>().enabled == false)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            temp = (int.Parse(score.text) + 1);
            score.text = temp.ToString();
            Debug.Log(score.text);
        }  
    }
}
