using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollect : MonoBehaviour
{
    public Transform[] spawnPoints; // Boþ nesnelerin konumlarý
    public GameObject symbolPrefab; // Simge prefab'ý

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
