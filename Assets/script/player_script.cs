using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
  
    
    public float Speed;
    public float JumpForce;
    public float gravityValue;
    public Rigidbody rb;
    public bool isGrounded = false;
    public bool isGrounded2 = false;

     void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
        }       
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded2 == true)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isGrounded2 = false;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded=true;
        isGrounded2 = true;
        if (collision.gameObject.tag == "terrain")
        {
            transform.position = new Vector3(-140, 35, -4);
            
        }
    }
}


