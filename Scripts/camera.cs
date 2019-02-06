using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//movimento della camera nell'asse Y e blocco dello schermo del telefono in verticale
public class camera : MonoBehaviour
{
public GameObject player;

void start()
{
  Screen.orientation = ScreenOrientation.Portrait;
}

void LateUpdate()
  {
   transform.position = new Vector3(0f, player.transform.position.y, -40f);
  }
}



 

 
