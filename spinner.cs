﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float x = 0f;
    [SerializeField] float y = 1f;
    [SerializeField] float z = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x,y,z);
    }
}
