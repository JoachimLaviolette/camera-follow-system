using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter2 : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 4f;
    public int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovements();
    }

    private void HandleMovements()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            waypoints[waypointIndex].transform.position,
            speed * Time.deltaTime
        );

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex++;
        }

        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
            Array.Reverse(waypoints, 0, waypoints.Length);
        }
    }
}
