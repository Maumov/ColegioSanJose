using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2_GoToWaypoints : MonoBehaviour
{
    public float rotationSpeed = 150f;
    public float movementSpeed = 10f;
    public int currentWaypoint;
    public List<GameObject> waypoints;
    internal bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            GoToWaypoint();
        }
    }

    public void StartMoving()
    {
        move = true;
    }

    public void GoToWaypoint()
    {
        Quaternion rot = Quaternion.LookRotation(waypoints[currentWaypoint].transform.position - transform.position, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 1f)
        {
            currentWaypoint++;
            if (currentWaypoint == waypoints.Count)
            {
                currentWaypoint = 0;
            }
        }
    }
}
