using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public enum PlayerControls { WASD, Arrows }
    public PlayerControls playerControls = PlayerControls.WASD;
    private float speed = 20.0f;
    private float turningSpeed = 25.0f;
    public float horizontalInput;
    public float verticalInput;
    public int sPressed = 0;
    public Camera firstPersonCamera;
    public Camera overheadCamera;
    public void ShowOverheadView()
    {
        sPressed = 0;
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView()
    {
        sPressed = 1;
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }

    public void Controller()
    {
        if(playerControls == PlayerControls.Arrows)
        {
            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");
        }
        else if(playerControls == PlayerControls.WASD)
        {
            verticalInput = Input.GetAxis("VerticalSecondPlayer");
            horizontalInput = Input.GetAxis("HorizontalSecondPlayer");
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("cola");
            Debug.Log(Input.GetAxis("VerticalSecondPlayer"));
        }
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        ShowOverheadView();
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turningSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && sPressed == 1) 
        {
            Debug.Log(sPressed);
            ShowOverheadView();
        }
        else if(Input.GetKeyDown(KeyCode.Space) && sPressed == 0)
        {
            ShowFirstPersonView();
        }
        

    }
}
