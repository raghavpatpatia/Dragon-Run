using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreValue.ToString();
    }
}
