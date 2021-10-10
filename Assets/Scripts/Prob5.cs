using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prob5 : MonoBehaviour
{  
    public float moveSpeed;
    private bool hasHit = false;

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
