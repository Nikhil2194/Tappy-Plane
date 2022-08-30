using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabs;


    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Spwan), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spwan));
    }


    private void Spwan()
    {
        GameObject pipes = Instantiate(prefabs, transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
