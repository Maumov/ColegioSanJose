using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Game2_GoToWaypoints : MonoBehaviour
{
    public GameObject nextCar;
    public bool move = false;
    public float rotationSpeed = 150f;
    public float movementSpeed = 10f;
    public int currentWaypoint;
    public List<GameObject> waypoints;


    public UnityEvent myEvent;
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
        GetComponent<Animator>().StopPlayback();
    }

    public void StopMoving()
    {
        move = false;
        GetComponent<Animator>().StartPlayback();
    }

    public void GoToWaypoint()
    {
        Quaternion rot = Quaternion.LookRotation(waypoints[currentWaypoint].transform.position - transform.position, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 1f)
        {
            if (!waypoints[currentWaypoint].GetComponent<Waypoint>().stopMoving)
            {
                currentWaypoint++;
            }
            else
            {
                currentWaypoint++;
                myEvent.Invoke();
            }

            if (currentWaypoint == waypoints.Count)
            {
                currentWaypoint = 0;
            }
        }
    }

    public void StartLeaveStudent()
    {
        StartCoroutine("LeaveStudent");
    }

    public GameObject student;
    public float timeToLeaveStudent, timeToLeaveCar;

    public IEnumerator LeaveStudent()
    {
        yield return new WaitForSeconds(timeToLeaveStudent);
        student.SetActive(true);

        yield return new WaitForSeconds(timeToLeaveCar);
        FindObjectOfType<Moving>().ChangePosition();
        yield return null;
    }

    public void ChangeCar()
    {   
            nextCar.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
    }
}
