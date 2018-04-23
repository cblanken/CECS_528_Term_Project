using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonHookableScript : MonoBehaviour {

    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NonHookable")
        {
            player.GetComponent<GrapplingHook>().collision = true;
            Debug.Log("collision = true");
            player.GetComponent<GrapplingHook>().hooked = false;
            player.GetComponent<GrapplingHook>().hookedobj = null;
        }
    }
}
