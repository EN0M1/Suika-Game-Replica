using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClawBehavior : MonoBehaviour
{
    public Vector2 newPosition;
    public Vector3 mousePosG;
    public float start;
    public float speed;
    Camera cam;
    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    CandyBehavior.spawnCandy();
        //}
    }

    void FixedUpdate()
    {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = Vector2.MoveTowards(transform.position, mousePosG, speed * Time.fixedDeltaTime);
        body.MovePosition(newPosition);
    }
}
