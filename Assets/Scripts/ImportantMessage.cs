using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantMessage : MonoBehaviour
{
    public GameObject entrada;
    public GameObject salida;

    public void ShowMessage()
    {
        entrada.SetActive(true);
        salida.SetActive(true);
    }
}
