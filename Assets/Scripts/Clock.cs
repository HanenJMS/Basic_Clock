using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hourPivot, minutePivot, secondPivot;
    const float hoursToDegrees = -30f, 
                minutesToDegrees = -6f, 
                secondsToDegree = -6f;
    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hourPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, hoursToDegrees * (float)time.TotalHours);

        minutePivot.localRotation = Quaternion.Euler(0.0f, 0.0f, minutesToDegrees * (float)time.TotalMinutes);
        
        secondPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, secondsToDegree * (float)time.TotalSeconds);
    }
}
