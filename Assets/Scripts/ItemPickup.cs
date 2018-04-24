using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {
	private Camera _camera;
	private Vector2 _center;
    private bool _itemInHand = false;
    private Transform _itemTransform; 
	void Start () {
		_camera = GetComponent<Camera>();
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update () {
		// PrimaryFire on left-click
		if (Input.GetKeyDown(KeyCode.E) && !_itemInHand) {
			Vector3 point = new Vector3 (_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
			Ray ray = _camera.ScreenPointToRay (point);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
                if (hit.transform.tag == "Item" && hit.distance < 1.5f){
                    _itemTransform = hit.transform;
                    hit.transform.parent = this.transform;
                    _itemInHand = true;
                }
            }
        }
        
        if (Input.GetKeyUp(KeyCode.E) && _itemInHand){
            _itemTransform.parent = null;
            _itemInHand = false;
        }
    }

	private IEnumerator PrimaryFire(Vector3 pos) {
		yield return new WaitForSeconds (1);
	}

	private IEnumerator SecondaryFire(Vector3 pos) {
		yield return new WaitForSeconds (1);
	} 
}
