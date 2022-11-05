using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force = 5;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("groundScoreGenerator"))
        {
            scoreManager.scoreValue++;
        }

        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
