using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //regola il menù di pausa
	public GameObject PauseUI;
    private bool paused = false;

	void Start()
    {
		PauseUI.SetActive (false);
    }

	void Update()
    {
        if (paused)
        {
            PauseUI.SetActive (true);
			Time.timeScale = 0;
		}
        if(!paused)
        {
            PauseUI.SetActive (false);
			Time.timeScale = 1;
		}
	}

	public void resume()
    {
		paused = false;
	}

	public void restart()
    {
		Application.LoadLevel (Application.loadedLevel);
	}

	public void MainMenu()
    {
		Application.LoadLevel (0);

	}

	public void Quit()
    {
		Application.Quit ();
	}

    public void setPause()
    {
        paused = !paused;
    }
}
