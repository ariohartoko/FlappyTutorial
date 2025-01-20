using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float timer = 0;
    private int minSpawn = -3;
    private int maxSpawn = 3;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
            timer += Time.deltaTime;
        else
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minSpawn, maxSpawn)), transform.rotation);
            timer = 0;
        }
    }
}
