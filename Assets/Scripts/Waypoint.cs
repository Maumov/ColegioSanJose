using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public bool stopMoving;

    public void StopCar()
    {
        FindObjectOfType<Game2_GoToWaypoints>().StopMoving();
    }

}
