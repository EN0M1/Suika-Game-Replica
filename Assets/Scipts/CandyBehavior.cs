using UnityEngine;

public class CandyBehavior : MonoBehaviour
{
    public static float cooldown = 0.0f;
    public GameObject[] candyVariants;
    public GameObject targetObject;
    GameObject newObject;
    public float startTime;
    public float minSpawn;
    public float maxSpawn;
    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initialPosition()
    {
        body = GetComponent<Rigidbody2D>();
        //body.position;
    }

    public void spawnCandy()
    {
        int numVariants = candyVariants.Length;
        if (numVariants > 0)
        {
            int selection = Random.Range(0, numVariants);
            newObject = Instantiate(candyVariants[selection], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
        startTime = Time.time;
    }
}
