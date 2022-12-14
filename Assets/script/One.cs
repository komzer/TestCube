using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class One : MonoBehaviour
{
    public Text textTime;
    public Text textSpeed;
    public Text textDistance;
    float   speed=2f, distance = 10f;
    float timeCreate = 1f;
    public GameObject box;
    private GameObject cubs;
     
    
    void Update()
    {
        textTime.text = timeCreate.ToString();
        textSpeed.text = speed.ToString();
        textDistance.text = distance.ToString();
    }

    public void UpTimeClick()
    {
        timeCreate++;
    }
    public void DownTimeClick()
    {
        timeCreate--;
    }
    public void UpSpeedClick()
    {
        speed++;
    }
    public void DownSpeedClick()
    {
        speed--;
    }
    public void UpDistanceClick()
    {
        distance++;
    }
    public void DownDistanceClick()
    {
        distance--;
    }
    void Start()
    {
        StartCoroutine(Shooting());
    }

  
    IEnumerator Shooting()
    {
        yield return new WaitForSeconds(timeCreate);

        cubs = Instantiate(box, box.transform.position, transform.rotation) as GameObject;
        cubs.transform.GetComponent<CubeMover>().SpeedInCube(speed);
        cubs.transform.GetComponent<CubeMover>().StepLineInCube(distance);

        StartCoroutine(Shooting());
    }
    public void ReadStringInputTime(string str)
    {
        if (str != "")
        {
            timeCreate = float.Parse(str);
        }
    }
    public void ReadStringInputStepLine(string str)
    {
        if (str != "")
        {
            distance = float.Parse(str);
        }
    }

    public void ReadStringInputSpeed(string str)
    {
        if (str != "")
        {
            speed = float.Parse(str);
        }
    }

}
