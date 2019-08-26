using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public List<PlaceToMove> placeToMove;
    int nextPosition = 0;
    
    public void CallStartMoving()
    {
        FindObjectOfType<Game2_GoToWaypoints>().StartMoving();
    }
    public void ChangePosition()
    {
        Debug.Log("Entre");
        if(placeToMove[nextPosition] != null)
        {
            gameObject.transform.position.Set(placeToMove[nextPosition].position.x, placeToMove[nextPosition].position.y, placeToMove[nextPosition].position.z);
            transform.rotation.Set(placeToMove[nextPosition].rotation.x, placeToMove[nextPosition].rotation.y, placeToMove[nextPosition].rotation.z, placeToMove[nextPosition].rotation.w);
//            gameObject.transform.rotation = placeToMove[nextPosition].rotation;
            nextPosition++;
        }
        else
        {
            Debug.Log("No hay posicion");
        }
    }

    [System.Serializable]
    public class PlaceToMove
    {
        public Vector3 position;
        public Quaternion rotation;
    }
}

