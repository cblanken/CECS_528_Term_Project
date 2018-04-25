using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject door = GameObject.Find("Door");
            door.SetActive(false);
        }
    }
}
