using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMotorScript : MonoBehaviour
{
    float speed = 5.0f;
    float rotSpeed = 100.0f;
    [SerializeField]
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float trans = Input.GetAxis("Vertical") * speed;
        float rot = Input.GetAxis("Horizontal") * rotSpeed;
        trans *= Time.deltaTime;
        rot *= Time.deltaTime;
        transform.Translate(0,0,trans);
        transform.Rotate(0,rot,0);


        if (trans != 0 || rot != 0 )
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}
