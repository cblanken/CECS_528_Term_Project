using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookablescripts : MonoBehaviour {

    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hookable")
        {
            player.GetComponent<GrapplingHook>().hooked = true;
            player.GetComponent<GrapplingHook>().hookedobj = other.gameObject;
        }
    }
}
