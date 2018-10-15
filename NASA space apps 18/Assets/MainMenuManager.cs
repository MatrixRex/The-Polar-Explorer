using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    public static string decade;

    public void GotoNorth()
    {
        Debug.Log("going north");
        SceneManager.LoadScene("Northstart");
    }

    public void GotoSouth()
    {
        Debug.Log("going south");
        //SceneManager.LoadScene("Southstart");
    }

    public void ChoosePresent()
    {
        decade ="pre";
        Debug.Log("present time");
    }
    public void Choose10()
    {
        decade = "10";
        Debug.Log("10 years ago");
    }
    public void Choose20()
    {
        decade = "20";
        Debug.Log("20 years ago");
    }


}
