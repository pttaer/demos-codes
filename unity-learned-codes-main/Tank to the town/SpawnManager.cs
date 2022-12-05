using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
        public float spawnRangeX = 18.0f;
        public GameObject[] vehiclePrefabs;
        public float startDelay = 0.5f;
        public float spawnInterval = 1.0f;

        // Update is called once per frame
        void Start()
        {
            InvokeRepeating("SpawnRandomVehicle", startDelay, spawnInterval);
        }

        void SpawnRandomVehicle()
        {
            Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, transform.position.z);
            Instantiate(CallPrefab(), spawnPos, CallPrefab().transform.rotation);
        }

        GameObject CallPrefab()
        {
            int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
            return vehiclePrefabs[vehicleIndex];
        }
}
