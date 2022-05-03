using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;
    Vector3 targetPosition;
    [SerializeField]
    [Range(0, 1f)]
    private float moveSpeed;
    int waypointIndex;
    public Transform playerStart;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = waypoints[0].position;
        startPos = playerStart.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)
        {
            //move towards the next waypoint
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.5f * moveSpeed);

            if (Vector3.Distance(transform.position, targetPosition) < 0.3f)
            {
                if (waypointIndex >= waypoints.Length - 1)
                {
                    waypointIndex = 0;
                }
                else
                {
                    waypointIndex++;
                }
                targetPosition = waypoints[waypointIndex].position;
            }

        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.transform.position = startPos;
        }
    }
}
