using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarco : MonoBehaviour
{
    //movimento del nemico Marco (fantasma blu)
    public float speed;
    Vector3 newScale;

    void Start()
    {
        newScale = transform.localScale;
        speed = 1.5f;

        if (newScale.x < 0)
        {
            newScale.x *= -1;
            transform.localScale = newScale;
        }
    }

    void Update()
    {
        newScale = transform.localScale;
        if (transform.position.x > 1.1f)
        {
            speed = -1.5f;
            newScale.x *= -1;
            transform.localScale = newScale;

        }
        if (transform.position.x < -1.0920f)
        {
            speed = 1.5f;
            newScale.x *= -1;
            transform.localScale = newScale;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}