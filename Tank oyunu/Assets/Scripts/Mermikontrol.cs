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
            // �arp��ma d��man ile olduysa d��man� yok et
            Destroy(collision.gameObject);
        }

        // �arp��ma oldu�unda mermiyi de yok et
        Destroy(gameObject);
    }
}