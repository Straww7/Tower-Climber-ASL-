using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void Start(){
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void play(){
        Application.LoadLevel("Game");
    }

    public void Credits(){
        Application.LoadLevel("Credits");
     }

    public void exit(){
        Application.Quit();
    }
}
