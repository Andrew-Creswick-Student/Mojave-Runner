using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float timer = 0.0f;
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;
    public GameObject obstaclePrefab4;
    public GameObject[] obstacleInstance;
    public int numberOfInstances = 10;
    public int instanceIndex = 0;
    public float minimumDelay = 1.0f;
    public float maximumDelay = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minimumDelay, maximumDelay);
        obstacleInstance = new GameObject[numberOfInstances];
        for(int i = 0; i< numberOfInstances; i++)
        {
            obstacleInstance[i] = Instantiate(obstaclePrefab);
            obstacleInstance[i].transform.position = transform.position;
            obstacleInstance[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0.0f)
        {
            SpawnObstacle();
            timer = Random.Range(minimumDelay, maximumDelay);
        }
    }
    void SpawnObstacle()
    {
        if (obstaclePrefab && !obstaclePrefab2)
        {
            obstacleInstance[instanceIndex].SetActive(true);
            obstacleInstance[instanceIndex].transform.position = transform.position;
            instanceIndex++;
            if(instanceIndex == numberOfInstances) instanceIndex = 0;
        }
        else if(obstaclePrefab2 && obstaclePrefab3 && obstaclePrefab4 && obstaclePrefab)
        {
            int randomSelected = Random.Range(1,4);
            switch (randomSelected)
            {
                case 1:
                    Instantiate(obstaclePrefab2, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(obstaclePrefab3, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(obstaclePrefab4, transform.position, Quaternion.identity);
                    break;
            }
        }
    }
}
