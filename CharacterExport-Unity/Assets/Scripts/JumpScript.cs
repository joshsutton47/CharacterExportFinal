using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JumpScript : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public Animator anim;
    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GameObject.FindGameObjectWithTag("Body").GetComponent<Animator>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

     void OnCollisionStay()
     {
        isGrounded = true;
        anim.SetBool("isGrounded", true);
    }

      void Update()
     {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
         {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            anim.SetBool("isGrounded", false);
        }
      }
}
