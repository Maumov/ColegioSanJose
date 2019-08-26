using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
//    public List<PlaceToMove> placeToMove;
    public List<GameObject> camerasToMove;
    int nextPosition = 0;
    
    public void CallStartMoving()
    {
        FindObjectOfType<Game2_GoToWaypoints>().StartMoving();
    }
    public void ChangePosition()
    {
        if(camerasToMove[nextPosition] != null)
        {
            //            this.gameObject.transform.position.Set(placeToMove[nextPosition].position.x, placeToMove[nextPosition].position.y, placeToMove[nextPosition].position.z);
            //            this.transform.rotation.Set(placeToMove[nextPosition].rotation.x, placeToMove[nextPosition].rotation.y, placeToMove[nextPosition].rotation.z, placeToMove[nextPosition].rotation.w);
            //            gameObject.transform.rotation = placeToMove[nextPosition].rotation;
            camerasToMove[nextPosition].gameObject.SetActive(true);
            this.gameObject.SetActive(false);
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

