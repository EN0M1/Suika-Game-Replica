using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    public Transform spawnPoint;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnFruit();
        }
    }

    void SpawnFruit()
    {
        int index = Random.Range(0, fruitPrefabs.Length);
        Instantiate(fruitPrefabs[index], spawnPoint.position, Quaternion.identity);
    }
}
