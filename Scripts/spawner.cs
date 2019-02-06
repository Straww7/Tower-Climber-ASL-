using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    //spawner che genera casualmente i nemici in posizioni casuali

    float RandX;
    public GameObject[]  elenco = new GameObject[5];
    GameObject temp;
    int indice;
    float RandxV=2f;
    Vector2 whereToSpawn;
    public int nEnemy;
    void Start()
    {
        nEnemy=Mathf.RoundToInt(Random.Range(0f, 1.0f));
        for (int i = 0; i < nEnemy; i++) {
            indice = Mathf.RoundToInt(Random.Range(0f, 4.0f));
            RandX = Random.Range(-0.7f, 0.7f);
            while (RandxV == RandX) {
                RandX = Random.Range(-0.7f, 0.7f);
            }
            temp = (GameObject)elenco[indice];
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(temp, whereToSpawn, Quaternion.identity);
            RandxV = RandX;
        }
    }
}


    
