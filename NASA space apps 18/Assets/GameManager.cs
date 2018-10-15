using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool isInBoat;

    public GameObject fpsController, fpsControllerBoat;
    public Transform boatExitPos;
    public GameObject restingUI;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && isInBoat)
        {
            fpsController.transform.position = boatExitPos.position;
            fpsController.SetActive(true);
            fpsControllerBoat.SetActive(false);
            isInBoat = false;
        }
    }



    public void TakeRest()
    {
        restingUI.SetActive(true);
    }
}
