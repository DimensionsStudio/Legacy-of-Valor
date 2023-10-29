﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameManagerScript.Instance.newPlane();
            gameObject.GetComponent<Collider>().enabled = false;
        }

    }
}
