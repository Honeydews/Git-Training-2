using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    public GameObject Go;
    public GameObject Go2;
    private float levels;

    public void Start()
    {
        go.SetActive(true);
    }

    public void ChangeActiveGo2()
    {
        go2.SetActive(true);
    }

    public void SetColor()
    {
        Go.GetComponent<Renderer>().color = Color.red;
    }

}   
