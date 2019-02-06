using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless : MonoBehaviour
{
    //Genera in continuazione la mappa
    public GameObject mappa;
    public GameObject platform;
    Vector3 posizione;
    float incremento=2.2f;

    void Update()
    {
        posizione = mappa.transform.position;
        if(Time.fixedTime%1 == 0)
        {
            posizione.y=posizione.y+incremento;
            Instantiate(mappa,posizione,Quaternion.identity);
            incremento+=2.2f;    
        }
    }
}
