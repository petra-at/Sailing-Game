using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMode : MonoBehaviour
{
    public GameObject Boat;
    public GameObject BoatCamera;
    public GameObject Player;
    public GameObject PlayerStartPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))// controlling the boat - 3rd Person mode
        {
            Boat.GetComponent<Rigidbody>().isKinematic = false;
            Boat.GetComponent<Boat>().enabled = true;
            BoatCamera.SetActive(true);

            Player.SetActive(false);
        }

        if (Input.GetKey("2")) // controlling the player - 1st Person mode 
        {
            Boat.GetComponent<Rigidbody>().isKinematic = true;
            Boat.GetComponent<Boat>().enabled = true;
            BoatCamera.SetActive(false);

            Player.SetActive(true);
            //Player.transform.position = PlayerStartPos.transform.position;
        }




    }
}
