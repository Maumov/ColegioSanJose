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
        Debug.Log("Cambie");
        if(camerasToMove != null)
        {
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

    public void CallChangeText()
    {
        FindObjectOfType<ChangeText>().NextText();
    }
}

