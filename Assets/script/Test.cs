using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

  //  public CubeMover cubeMover;

    float stepLength = 2f , speed = 3f ;

    void Update()
    {
        print("speed in Update " + speed);
    }
    public void SpeedInCube(float t)
    {
        speed = t;
        print("speed in function " + speed);

    }
    public void StepLineInCube(float t)
    {
        stepLength = t;
       
      //print("111 " + stepLength  );
    }

  
    public void startDeath()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    //   cubeMover.StepLineInCube(stepLength);
    // cubeMover.SpeedInCube(speed);
    //   print( stepLength + speed);
}
