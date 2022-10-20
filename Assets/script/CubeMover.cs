using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
   
    Vector3 end;
     float distance = 10f;
     float speed = 2f;
    void Start()
    {
       transform.position = new Vector3(0f, 0f, 0f);
        end = transform.position + new Vector3(distance,0f,0f);


    }
    public void StepLineInCube(float t)
    {
        distance = t;
    }

    public void SpeedInCube(float t)
    {
        speed = t;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, end, speed * Time.deltaTime);
        if (transform.position == end)
        {
            Destroy(gameObject);
           // gameObject.GetComponentInParent<Test>().startDeath();
        }
    }

   
   

}
