using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    private Vector3 playerInput;
    public CharacterController Player;
    public float playerspeed;
    private Vector3 moveplayer;
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;

    public float gravity=9.8f;
    public float fallvelocity;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        moveplayer = playerInput.x * camRight + playerInput.z * camForward;
        moveplayer = moveplayer * playerspeed;
        Player.transform.LookAt(Player.transform.position + moveplayer);
        SetGravity();
        Player.Move(moveplayer * Time.deltaTime);
        
        Debug.Log(Player.velocity.magnitude);

        
    }
    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;
        camForward.y = 0;
        camRight.y = 0;
        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
    void SetGravity()
    {
        
        if(Player.isGrounded)
        {
           fallvelocity = -gravity * Time.deltaTime;
            moveplayer.y = fallvelocity;
        }
        else
        {
            fallvelocity -= gravity * Time.deltaTime;
            moveplayer.y = fallvelocity;
        }
    }
 
}
