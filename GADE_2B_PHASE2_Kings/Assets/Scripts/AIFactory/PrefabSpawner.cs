using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnRatePerMinute = 1;

    private int currentCount = 0;
    

    [SerializeField]
    private AIRacerFactory factory;
    private void Update()
    {
        var targetCount = 3;


        while (targetCount > currentCount)
        {
            var inst = factory.GetPrefab();
            inst.transform.position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-5.0f, 5.0f), 0);
            currentCount++;
        }
    }
}
