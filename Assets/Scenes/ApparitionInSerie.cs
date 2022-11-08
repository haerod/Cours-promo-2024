using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparitionInSerie : MonoBehaviour
{
    public GameObject ballPrefab;

    private void Start()
    {
        for (int tour = 0; tour < 200; tour++)
        {
            CreateBall(tour,0);
        }
    }

    public void CreateBall(float x, float y)
    {
        Instantiate(ballPrefab, new Vector3(x,y,0), Quaternion.identity);
    }
}
