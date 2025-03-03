using UnityEngine;

public class FruitBehavior : MonoBehaviour
{
    public int fruitIndex; // Index of the fruit (0 = smallest, increasing sizes)
    public GameObject[] fruitPrefabs; // Prefabs for larger fruits
    
    private bool hasMerged = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Fruit otherFruit = collision.gameObject.GetComponent<Fruit>();

        if (otherFruit != null && otherFruit.fruitIndex == fruitIndex && !hasMerged && !otherFruit.hasMerged)
        {
            Merge(otherFruit);
        }
    }

    void Merge(Fruit otherFruit)
    {
        if (fruitIndex < fruitPrefabs.Length - 1)
        {
            Vector3 mergePosition = (transform.position + otherFruit.transform.position) / 2;
            GameObject newFruit = Instantiate(fruitPrefabs[fruitIndex + 1], mergePosition, Quaternion.identity);
            newFruit.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        hasMerged = true;
        otherFruit.hasMerged = true;
        
        Destroy(otherFruit.gameObject);
        Destroy(gameObject);
    }
}
