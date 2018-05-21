using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour {

    public void changescene(string scenename)
    {
        Application.LoadLevel(scenename);
        //Application loads level specified by "scenenaem"
    }
	public void quitgame() //btnQuit
    {
        Debug.Log("The application has closed!");
        Application.Quit();
        //Application closes
    }
    public void restartGame() //#btnRestart
    {
        Application.LoadLevel(Application.loadedLevel);
    }







}   



