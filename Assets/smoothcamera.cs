﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothcamera : MonoBehaviour
{   
    //Values that need to be change according  to mas values of map
    [SerializeField] Transform  target;
    [SerializeField] float xMin = -100;
    [SerializeField] float xMax = 100;
    [SerializeField] float yMin = -100;
    [SerializeField] float yMax = 100;
    // Start is called before the first frame update

    Transform t;
    public void Awake(){
        t=transform;
    }
    public Vector3 offset;
    void LateUpdate()
    {
        float x = Mathf.Clamp(target.position.x,xMin,xMax);
        float y = Mathf.Clamp(target.position.x,yMin,yMax);
        t.position=new Vector3(x,y,t.position.z);
    }
}