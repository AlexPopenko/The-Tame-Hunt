using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IAction, IMovement
{
    public float speed = 7.0f;
    public float floatSpeed = 3.0f;
    private Rigidbody PlayerRB;
    public float rotationSpeed = 7.0f;
    public bool touchedBook = false;

    //private float jumpForce = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
     PerformAction();  
     IMovement();
     
    }
    public void PerformAction(){
            
    }

    public void IMovement(){
            float horizontalInput = Input.GetAxis("Horizontal");
            float forwardInput = Input.GetAxis("Vertical");
            float upDown = Input.GetAxis("Jump");

        //PlayerRB.MovePosition(Vector3.forward * speed * forwardInput);
        transform.position += transform.forward * speed * Time.deltaTime * forwardInput;
        transform.position += transform.up * floatSpeed * Time.deltaTime * upDown;


        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);

        
    }

    
    // private void touchBook(Collision collision)
    // {
    //     touchedBook = true;
    // }


    //public void 
}
