using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    //script assegnato ai nemici statici (pianta e palla spinata)
    private void OnCollisionEnter2D(Collision2D col)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
