using UnityEngine;
using System.Collections;

public class SetScreenSize : MonoBehaviour
{
    //Ridimensionamento della telecamera in base alla grandezza dello schermo del cellulare
    public GameObject limiteInferiore, limiteSx;
    private float height;

    void Start()
    {
        SetScreenDimensionByElementsOnScreen();
    }

    private void SetScreenDimensionByElementsOnScreen()
    {
        float ySize = Mathf.Abs(limiteInferiore.transform.position.y);
        float xSize = Mathf.Abs(limiteSx.transform.position.x);
        Camera.main.orthographicSize = ySize;
        if (Camera.main.orthographicSize * Camera.main.aspect < xSize)
        {
            Camera.main.orthographicSize = xSize / Camera.main.aspect;
        }
    }
}