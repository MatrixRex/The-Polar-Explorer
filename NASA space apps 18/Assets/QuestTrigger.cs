using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour {

    public GameObject fpsController,fpsControllerBoat;
    public GameObject ShowQuest,showBoatInfo;
    public GameObject boatSittingPos;
    public GameObject camp;
    public GameObject restingUI;

    public bool initialQuest, boatQuest, buidCamp,restCamp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (boatQuest)
            {
                showBoatInfo.SetActive(true);
                fpsController.SetActive(false);
                fpsControllerBoat.SetActive(true);
                GameManager.isInBoat = true;
            }

            if (initialQuest)
            {
                ShowQuest.SetActive(true);
                this.gameObject.SetActive(false);
            }

            if(buidCamp)
            {
                Destroy(this.gameObject);
               GameObject go = Instantiate(camp, transform.position, transform.rotation);

                //go.SetActive(true);
            }
            if(restCamp)
            {
                restingUI.SetActive(true);
            }
        }
    }
}
