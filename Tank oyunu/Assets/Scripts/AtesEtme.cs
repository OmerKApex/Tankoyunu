using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairKontrol : MonoBehaviour
{
    public Transform firlatmaNoktasi; // K�relerin f�rlat�laca�� nokta
    public GameObject kurePrefab; // K�re prefab'i (f�rlat�lacak obje)
    public float atisGucu = 10f; // F�rlatma g�c�
    public float kureOmru = 3f; // K�renin �mr� (saniye)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FirlatKure();
        }
    }

    void FirlatKure()
    {
        GameObject yeniKure = Instantiate(kurePrefab, firlatmaNoktasi.position, firlatmaNoktasi.rotation);
        Rigidbody kureRigidbody = yeniKure.GetComponent<Rigidbody>();

        if (kureRigidbody != null)
        {
            Vector3 firlatmaYonu = firlatmaNoktasi.forward;
            float firlatmaHizi = atisGucu;

            kureRigidbody.velocity = firlatmaYonu * firlatmaHizi;
        }

        Destroy(yeniKure, kureOmru);
    }
}