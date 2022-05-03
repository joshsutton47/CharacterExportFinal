using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Transform teleportTo;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " Entered the Trigger");
        other.transform.position = teleportTo.position;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " Is in the Trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " Exited the Trigger");
    }
}
