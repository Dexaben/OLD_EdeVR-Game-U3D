﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timertrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("Finnish");
    }
}
