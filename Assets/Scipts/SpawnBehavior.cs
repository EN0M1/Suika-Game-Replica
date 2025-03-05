using UnityEngine;
using System.Collections;

public class SpawnBehavior : MonoBehaviour
{
    public GameObject[] candyVariants;
    public float cooldown;
    GameObject currentCandy;
    GameObject newObject;
    public float timeSinceLastSpawn;
    Rigidbody2D body;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timeSinceLastSpawn >= cooldown)
        {
            spawnCandy();
            timeSinceLastSpawn = 0.0f;
        }
    }

    public void spawnCandy()
    {
        GameObject spawnPoint = GameObject.FindWithTag("SpawnPoint");
        int numVariants = candyVariants.Length;
        if (numVariants > 0)
        {
            int selection = Random.Range(0, numVariants);
            newObject = Instantiate(candyVariants[selection], spawnPoint.transform.position, Quaternion.identity);
        }
    }

    public void deSpawn()
    {
        GameObject[] candy = GameObject.FindGameObjectsWithTag("Candy");

        for (int i = 0; i < candy.Length; i++)
        {
            Destroy(candy[i]);
        }
    }
}

