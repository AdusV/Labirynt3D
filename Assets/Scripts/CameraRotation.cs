﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    [SerializeField] [Range(0f, 5f)] float lerpTime;
    [SerializeField] Vector3[] myAngles;

    int angleIndex;
    int len;
    float t = 0f;

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(myAngles[angleIndex]), lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .180)
        {
            t = 0f;
            angleIndex = Random.Range(0, len - 1);
        }
    }
}
