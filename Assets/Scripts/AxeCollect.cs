using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollect : MonoBehaviour
{
    public Transform[] spawnPoints; // Bo� nesnelerin konumlar�
    public GameObject symbolPrefab; // Simge prefab'�

    void Start()
    {
        SpawnSymbols();
    }

    void SpawnSymbols()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(symbolPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
