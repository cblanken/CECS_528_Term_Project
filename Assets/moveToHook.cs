using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToHook : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject hookHolder = GameObject.Find("Hook");
		this.transform.position = new Vector3(hookHolder.transform.position.x, hookHolder.transform.position.y, hookHolder.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject hookHolder = GameObject.Find("Hook");
        this.transform.position = new Vector3(hookHolder.transform.position.x, hookHolder.transform.position.y, hookHolder.transform.position.z);
    }
}
