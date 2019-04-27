﻿using System.Collections;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;

    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }

}
