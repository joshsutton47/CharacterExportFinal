using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBPlayerContoller : MonoBehaviour
{
    Rigidbody rb;
    Vector3 inputVector;
    public float speed = 10.0f;
    public LayerMask rbGroundMask;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y , Input.GetAxis("Vertical") * speed);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }


        //Jump
        if (Input.GetButtonDown("Jump") && GroundCheck())
        {
            rb.AddForce(Vector3.up * 10.0f, ForceMode.Impulse);
        }

        rb.velocity = inputVector * Time.deltaTime;
          
    }

    bool GroundCheck()
    {
        float dist = GetComponent<Collider>().bounds.extents.y + 0.01f;
        Ray ray = new Ray(transform.position, Vector3.down);

        return Physics.Raycast(ray, dist, rbGroundMask);
    }

}
