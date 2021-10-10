using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prob6 : MonoBehaviour
{
    public float moveSpeed;
    private bool hasHit = false;

    [SerializeField]
    private GameObject star1;

    [SerializeField]
    private GameObject star2;

    [SerializeField]
    private GameObject star3;
    public void Start()
    {
        randomSpawn();
    }

    public void randomSpawn()
    {
        var randNum = Random.Range(0, 3);
        for (var i = 0; i < randNum; i++)
        {
            //Instantiate(star1, screenPosition, Quaternion.identity);
            bool starSpawned = false;
            while (!starSpawned)
            {
                Vector3 starPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
                if ((starPosition - transform.position).magnitude < 3)
                {
                    continue;
                }
                else
                {

                    Instantiate(star1, starPosition, Quaternion.identity);
                    starSpawned = true;
                }
            }

        }
        for (var i = 0; i < randNum; i++)
        {
            bool starSpawned = false;
            while (!starSpawned)
            {
                Vector3 starPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
                if ((starPosition - transform.position).magnitude < 3)
                {
                    continue;
                }
                else
                {

                    Instantiate(star2, starPosition, Quaternion.identity);
                    starSpawned = true;
                }
            }
        }
    }

    public void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Equals("tiang2"))
        {
            moveSpeed = 0.5f;
        }
        if (collision.gameObject.name.Equals("tiang1"))
        {
            moveSpeed = 0.5f;
        }
        if (collision.gameObject.name.Equals("tiang3"))
        {
            moveSpeed = 0.5f;
        }
        if (collision.gameObject.name.Equals("tiang4"))
        {
            moveSpeed = 0.5f;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        moveSpeed = 3;
    }

}
