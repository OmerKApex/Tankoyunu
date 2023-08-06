using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiKontrol : MonoBehaviour
{
    public float mermiHizi = 10f;

    private void Update()
    {
        // Mermi ileri hareketi
        transform.Translate(Vector3.forward * mermiHizi * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("dusman"))
        {
            // Çarpýþma düþman ile olduysa düþmaný yok et
            Destroy(collision.gameObject);
        }

        // Çarpýþma olduðunda mermiyi de yok et
        Destroy(gameObject);
    }
}