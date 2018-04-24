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
        if(other.tag != "Hookable" && other.tag != "Player" && other.tag != "HookHolder")
        {
            player.GetComponent<GrapplingHook>().collision = true;
            player.GetComponent<GrapplingHook>().hooked = false;
            player.GetComponent<GrapplingHook>().hookedobj = null;
            player.GetComponent<GrapplingHook>().ReturnHook();
        }
    }
}
