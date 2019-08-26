using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public List<string> puerta1, puerta2, puerta3;
    public bool door1, door2, door3;
    public int currentText;

    private void Start()
    {
        NextText();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextText();
        }
        
    }

    public void NextText()
    {
        if (door1)
        {
            if (currentText == -1 || currentText > puerta1[currentText].Length)
            {
                Debug.Log("Null");
            }
            else
            {
                GetComponent<TextMeshProUGUI>().text = puerta1[currentText];
                currentText++;
            }
        }

        if (door2)
        {
            if (currentText == -1 || currentText > puerta2[currentText].Length)
            {
                Debug.Log("Null");
            }
            else
            {
                GetComponent<TextMeshProUGUI>().text = puerta2[currentText];
                currentText++;
            }
        }

        if (door3)
        {
            if (currentText == -1 || currentText > puerta3[currentText].Length)
            {
                Debug.Log("Null");
            }
            else
            {
                GetComponent<TextMeshProUGUI>().text = puerta3[currentText];
                currentText++;
            }
        }
    }
}
