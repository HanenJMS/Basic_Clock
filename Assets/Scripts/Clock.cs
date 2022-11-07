using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hourPivot, minutePivot, secondPivot;
    DateTime time = DateTime.Now;
    const float hoursToDegrees = -30f, 
                minutesToDegrees = -6f, 
                secondsToDegree = -6f;
    int currentHour, currentMinute, currentSecond;
    private void Awake()
    {
        currentHour = time.Hour;
        UpdateTime(hourPivot, hoursToDegrees, time.Hour);
        currentMinute = time.Minute;
        UpdateTime(minutePivot, minutesToDegrees, time.Minute);
        currentSecond = time.Second;
        UpdateTime(secondPivot, secondsToDegree, time.Second);
    }
    private void Update()
    {
        time = DateTime.Now;

        if(time.Hour != currentHour)
        {
            UpdateTime(hourPivot, hoursToDegrees, time.Hour);
            currentHour = time.Hour;
        }
        else if(time.Minute != currentMinute)
        {
            UpdateTime(minutePivot, minutesToDegrees, time.Minute);
            currentMinute = time.Minute;
        }
        else if(time.Second != currentSecond)
        {
            UpdateTime(secondPivot, secondsToDegree, time.Second);
            currentSecond = time.Second;
        }
    }

    private void UpdateTime(Transform transform, float degree, int Time)
    {
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, degree * Time);
    }
}
