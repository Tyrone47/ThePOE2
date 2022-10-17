using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    private T Prefab;

    public T GetPrefab()
    {
        return Instantiate(Prefab);
    }
}
