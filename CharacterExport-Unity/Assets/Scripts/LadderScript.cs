using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour
{
    public Transform playerTransform;
    public bool insideLadder;
    public float ladderHeight = 4;
    public RBPlayerContoller rbController;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rbController = GetComponent<RBPlayerContoller>();
        insideLadder = false;
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ladder") {
            rbController.enabled = true;
            rb.useGravity = true;
            insideLadder = !insideLadder;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Ladder")
        {
            rbController.enabled = false;
            rb.useGravity = false;
            insideLadder = !insideLadder;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if on ther ladder and holding w climb ladder

        if (insideLadder == true && Input.GetKey("w"))
        {
            playerTransform.transform.position += Vector3.up / ladderHeight;
        }
        
    }
}
