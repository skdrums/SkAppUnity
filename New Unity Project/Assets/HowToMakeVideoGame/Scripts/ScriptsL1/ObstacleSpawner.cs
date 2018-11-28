
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject[] Ob;
    private float timeToSpawn = 0.1f;
    public float timeBetweenWaves = 1f;
    public float forwardForce = 2000f;
    public Rigidbody rb;

    void Start()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    // Use this for initialization
    void FixedUpdate () {
       
        if (Time.time >= timeToSpawn)
        {
            SpawnObstacles();
           
           
            timeToSpawn = Time.time + timeBetweenWaves;
        }
      
	}
	
	void SpawnObstacles()
    {
        int[] randomIndex = { Random.Range(0, spawnPoints.Length), Random.Range(0, spawnPoints.Length) };



        for (int i = 0; i < spawnPoints.Length; i++)
        {
            float x = Random.Range(1, 15);
            if (randomIndex[0] != i && randomIndex[1] != i)
            {
                Instantiate(Ob[Random.Range(0,Ob.Length)], spawnPoints[i].position+new Vector3(x,0,0), Quaternion.identity);
            }
        }

    }


}
