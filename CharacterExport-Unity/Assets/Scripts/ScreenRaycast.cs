using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRaycast : MonoBehaviour
{
    Camera cam;
    Vector3 rayPos;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        rayPos = new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0);
        Ray ray = cam.ScreenPointToRay(rayPos);

        Debug.DrawRay(rayPos, cam.transform.forward * 1000, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray.origin, ray.direction, out hit, 10000)) {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
