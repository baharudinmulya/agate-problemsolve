using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prob8 : MonoBehaviour
{
    public float moveSpeed;
    private bool hasHit = false;
  

    [SerializeField]
    private GameObject star1;

    [SerializeField]
    private GameObject star2;

    [SerializeField]
    private GameObject star3;
    // Start is called before the first frame update
    scoreController pointsToAdd;
    public int score1 = 1;
    public int score2 = 2;
    private IEnumerator coroutine;

    void Start()
    {
        randomSpawn();
    }
    public void randomSpawn()
    {
        var randNum = Random.Range(2, 5);
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

                    Instantiate(star3, starPosition, Quaternion.identity);
                    starSpawned = true;
                }
            }

        }
    }
    public IEnumerator SpawnStar()
    {
        yield return new WaitForSeconds(3f);
        bool starSpawned = false;
        while (!starSpawned)
        {
            Vector3 starPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((starPosition - transform.position).magnitude< 3)
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

    public IEnumerator SpawnStar1()
    {
        yield return new WaitForSeconds(3f);
        bool starSpawned1 = false;
        while (!starSpawned1)
        {
            Vector3 starPosition1 = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((starPosition1 - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(star2, starPosition1, Quaternion.identity);
                starSpawned1 = true;
                
            }


        }
    }

    public IEnumerator SpawnStar2()
    {
        yield return new WaitForSeconds(3f);
        bool starSpawned2 = false;
        while (!starSpawned2)
        {
            Vector3 starPosition2 = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((starPosition2 - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(star3, starPosition2, Quaternion.identity);
                starSpawned2 = true;
                
            }


        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("star1(Clone)"))
        {
            Destroy(collision.gameObject);
            StartCoroutine("SpawnStar", 3f);

        }
        if (collision.gameObject.name.Equals("star2(Clone)"))
        {
            Destroy(collision.gameObject);
            StartCoroutine("SpawnStar1", 2.0f);
        }
        if (collision.gameObject.name.Equals("star3(Clone)"))
        {
            Destroy(collision.gameObject);
            StartCoroutine("SpawnStar2", 2.0f);
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
