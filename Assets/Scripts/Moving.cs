using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
//    public List<PlaceToMove> placeToMove;
    public GameObject camerasToMove;
    
    public void CallStartMoving()
    {
        FindObjectOfType<Game2_GoToWaypoints>().StartMoving();
    }
    public void ChangePosition()
    {
        if(camerasToMove != null)
        {
            //            this.gameObject.transform.position.Set(placeToMove[nextPosition].position.x, placeToMove[nextPosition].position.y, placeToMove[nextPosition].position.z);
            //            this.transform.rotation.Set(placeToMove[nextPosition].rotation.x, placeToMove[nextPosition].rotation.y, placeToMove[nextPosition].rotation.z, placeToMove[nextPosition].rotation.w);
            //            gameObject.transform.rotation = placeToMove[nextPosition].rotation;
            camerasToMove.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("No hay posicion");
        }
    }

    public void CanChangeCar()
    {
        FindObjectOfType<Game2_GoToWaypoints>().ChangeCar();
    }
    
}

