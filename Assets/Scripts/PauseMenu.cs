using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public GameObject player;
    public Camera mainCamera;
    private Canvas canvas;
    public bool paused;

    void Start()
    {
        paused = false;
        canvas = GameObject.Find("PauseMenu").GetComponent<Canvas>();
        canvas.enabled = false;
    }
    
    void Update () {
        if (Input.GetKeyDown(KeyCode.P) && !paused)
        {
            Cursor.lockState = CursorLockMode.None;
            player.GetComponent<MouseLook>().enabled = false;
            player.GetComponent<GrapplingHook>().enabled = false;
            mainCamera.GetComponent<MouseLook>().enabled = false;
            canvas.enabled = true;
            paused = true;
        }

        else if (Input.GetKeyDown(KeyCode.P) && paused)
        {
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<MouseLook>().enabled = true;
            player.GetComponent<GrapplingHook>().enabled = true;
            mainCamera.GetComponent<MouseLook>().enabled = true;
            canvas.enabled = false;
            paused = false;
        }
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<MouseLook>().enabled = true;
        player.GetComponent<GrapplingHook>().enabled = true;
        mainCamera.GetComponent<MouseLook>().enabled = true;
        canvas.enabled = false;
        paused = false;
    }
    public void Exit()
    {
        EditorApplication.ExecuteMenuItem("Edit/Play");
    }
}
