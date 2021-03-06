using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prob4 : MonoBehaviour
{
    //inisialisasi rb2d
    private Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    // Tombol untuk menggerakkan ke atas
    public KeyCode upButton = KeyCode.W;

    // Tombol untuk menggerakkan ke bawah
    public KeyCode downButton = KeyCode.S;

    // Tombol untuk menggerakkan ke atas
    public KeyCode rightButton = KeyCode.D;

    // Tombol untuk menggerakkan ke bawah
    public KeyCode leftButton = KeyCode.A;

    public float speed;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void input()
    {



    }
    // Update is called once per frame
    void Update()
    {

        // Dapatkan kecepatan raket sekarang.
        Vector2 velocity = rigidBody2D.velocity;

        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

        //X
        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.x = 0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

        // Dapatkan posisi raket sekarang.
        Vector3 position = transform.position;

        // Masukkan kembali posisinya ke transform.
        transform.position = position;
    }
}
