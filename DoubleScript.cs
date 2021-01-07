using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleScript : MonoBehaviour
{
    private float speed;
    public GameObject Global;

    public void Update()
    {
        Find("Global");
    }
    public void Endline()
    {
        Application.Quit();
    }
}
