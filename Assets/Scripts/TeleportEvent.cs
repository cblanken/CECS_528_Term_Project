using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
            Application.LoadLevel("Level_02");
    }
}
