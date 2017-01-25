﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletTrigger : MonoBehaviour
{
    public GameObject manager;
    public bool hit;

    void OnTriggerEnter(Collider other)
    {
        hit = true;
        manager.GetComponent<Manager>().loop();
    }
}
