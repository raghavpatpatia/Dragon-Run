using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directionMove : MonoBehaviour
{
    public float dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(dir, 0);
        transform.Translate(pos * Time.deltaTime, 0);
    }
}
