using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class CheckpointSystem : MonoBehaviour
{
    [Header("Cars")]
    public Transform Car01;
    public Transform Car02;
    public Transform Car03;
    public Transform Car04;

    [Header("Distances")]
    public float Car01Dist;
    public float Car02Dist;
    public float Car03Dist;
    public float Car04Dist;

    [Header("Placements")]
    public float First;
    public float Second;
    public float Third;
    public float Fourth;


    public TextMeshProUGUI PlayerPosDisplay;
    public int playerPos;
    void Start()
    {

    }


    void Update()
    {
        Car01Dist = Vector3.Distance(transform.position, Car01.position);
        Car02Dist = Vector3.Distance(transform.position, Car02.position);
        Car03Dist = Vector3.Distance(transform.position, Car03.position);
        Car04Dist = Vector3.Distance(transform.position, Car04.position);

        First = Mathf.Min(Car01Dist, Car02Dist, Car03Dist, Car04Dist);
        Fourth = Mathf.Max(Car01Dist, Car02Dist, Car03Dist, Car04Dist);

        #region Third

        if (Car01Dist < Fourth && Car01Dist > First)
        {
            Third = Car01Dist;
        }

        if (Car02Dist < Fourth && Car02Dist > First)
        {
            Third = Car02Dist;
        }

        if (Car03Dist < Fourth && Car03Dist > First)
        {
            Third = Car03Dist;
        }

        if (Car04Dist < Fourth && Car04Dist > First)
        {
            Third = Car04Dist;
        }
        #endregion

        #region Second
        if (Car01Dist != First && Car01Dist != Third && Car01Dist != Fourth)
        {
            Second = Car01Dist;
        }

        if (Car02Dist != First && Car02Dist != Third && Car02Dist != Fourth)
        {
            Second = Car02Dist;
        }

        if (Car03Dist != First && Car03Dist != Third && Car03Dist != Fourth)
        {
            Second = Car03Dist;
        }

        if (Car04Dist != First && Car04Dist != Third && Car04Dist != Fourth)
        {
            Second = Car01Dist;
        }
        #endregion
        if (Car01Dist == First)
        {
            playerPos = 1;
        }

        if (Car01Dist == Second)
        {
            playerPos = 2;
        }

        if (Car01Dist == Third)
        {
            playerPos = 3;
        }

        if (Car01Dist == Fourth)
        {
            playerPos = 4;
        }
        PlayerPosDisplay.text = playerPos + "/" + 4;
    }
}