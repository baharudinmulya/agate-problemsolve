using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupStar : MonoBehaviour
{
    public int scoreToGive;
    private scoreController theScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<scoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        theScoreManager.AddScore(scoreToGive);
    }
}
