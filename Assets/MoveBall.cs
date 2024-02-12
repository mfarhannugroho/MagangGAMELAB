using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rg;
    public float speed; // Kecepatan bola
    public float jumpSpeed; // Kecepatan loncat bola

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody> (); // Mengambil komponen Rigidbody pada objek
    }

    // Update is called once per frame
    void Update()
    {
        // Jika tombol spasi ditekan
        if (Input.GetKey (KeyCode.Space)) {
            Vector3 atas = new Vector3 (0, 20, 0); // Membuat vektor untuk arah loncat ke atas
            rg.AddForce (atas * jumpSpeed); // Menambahkan gaya loncat ke atas pada bola
        }

        Vector3 gerak = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")); // Membuat vektor gerakan dari input horizontal dan vertical
        rg.AddForce (gerak * speed); // Menambahkan gaya gerakan pada bola sesuai dengan input
    }
}