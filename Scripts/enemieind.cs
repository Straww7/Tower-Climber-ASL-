using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemieind : MonoBehaviour
{
    //Movimento automatico del nemico "Carlo" (quadro con gli spuntoni) accellera ogni volta che va verso sinistra
    public float speed;

    void Start()
    {
        speed=1f;
    }

    void Update()
    {

        if (transform.position.x > 1.1f)
        {
            speed = speed * -1;
            speed -= 2f;
        }
        if (transform.position.x < -1.0920f)
        {
            speed = speed * -1;
            speed = 1f;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Application.LoadLevel (Application.loadedLevel);
    }
}
