using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        RaycastHit hit;


        if (Input.GetKey(KeyCode.P)) {
            Debug.DrawRay(transform.position, transform.forward * 100, Color.green);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100)) {

                Debug.Log(hit.collider.gameObject.name);
                Destroy(hit.collider.gameObject);

            }
        }
    }
}
