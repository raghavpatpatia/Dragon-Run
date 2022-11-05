using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
    public GameObject ground;
    public float height;
    public float startTimeBetweenSpwan;
    private float timeBetweenSpawn;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBetweenSpawn <= 0)
        {
            GameObject newGround = Instantiate(ground, spawnPoint.position, Quaternion.identity);
            newGround.transform.position = spawnPoint.position + new Vector3(0, Random.RandomRange(-height, height), 0);
            timeBetweenSpawn = startTimeBetweenSpwan;
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
