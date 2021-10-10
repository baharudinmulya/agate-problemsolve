using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prob9 : MonoBehaviour
{
    public float moveSpeedmusuh=0;
    public scoreController comparation;
    public int score = 7;
    // Start is called before the first frame update
    void Start()
    {
        comparation = FindObjectOfType<scoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (comparation.currentScore > score && comparation.currentScore <= 19)
        {
            moveSpeedmusuh = 1;
            var pos = GameObject.Find("Circle").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, pos, moveSpeedmusuh * Time.deltaTime);
            
        }
        if (comparation.currentScore >= 20 && comparation.currentScore < 39)
        {
            moveSpeedmusuh = 2;
            var pos = GameObject.Find("Circle").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, pos, moveSpeedmusuh * Time.deltaTime);
        }

        if (comparation.currentScore >= 39 && comparation.currentScore < 49)
        {
            moveSpeedmusuh = 3;
            var pos = GameObject.Find("Circle").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, pos, moveSpeedmusuh * Time.deltaTime);
        }

        if (comparation.currentScore >= 49 && comparation.currentScore < 59)
        {
            moveSpeedmusuh = 4;
            var pos = GameObject.Find("Circle").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, pos, moveSpeedmusuh * Time.deltaTime);
        }

        if (comparation.currentScore >= 59 && comparation.currentScore < 69)
        {
            moveSpeedmusuh = 5;
            var pos = GameObject.Find("Circle").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, pos, moveSpeedmusuh * Time.deltaTime);
        }
        // Debug.Log("posisi musuh:" + transform.position);
        //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
}
