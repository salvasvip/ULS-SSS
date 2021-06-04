using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astronautController : MonoBehaviour
{
    //////Character/////////
    CharacterController player;
    public float walkSpeed = 5.0f;
    public float runSpeed = 10.0f;
    public float gravity = 20.0f;

    ///////Camera//////////////
    public Camera cam;
    public float mouseHorizontal = 2.0f;
    public float mouseVertical = 2.0f;
    public float minRotation = -65.0f;
    public float maxRotation =  65.0f;

    float h_mouse,v_mouse;

    Vector3 move = Vector3.zero;

    void Start()
    {
        player = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse += mouseVertical * Input.GetAxis("Mouse Y");

        v_mouse = Mathf.Clamp(v_mouse,minRotation,maxRotation);

        cam.transform.localEulerAngles = new Vector3(-v_mouse,0,0);
        transform.Rotate(0,h_mouse,0);

        if(player.isGrounded){
            move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
            if(Input.GetKey(KeyCode.LeftShift)){
                move = transform.TransformDirection(move) * runSpeed;
            }else{
                move = transform.TransformDirection(move) * walkSpeed; 
            }
        }

        move.y -= gravity * Time.deltaTime;

        player.Move(move * Time.deltaTime);
    }
}
