using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleScript : MonoBehaviour
{
    private float speed;        // speed 선언
    public GameObject Global;

    public void Update()
    {
        Find("Global");
    }

    // SetSpeed는 파라미터 v로 speed를 설정함.
    private void SetSpeed(float v)
    {
        speed = v;
    }
}
