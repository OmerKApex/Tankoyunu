using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairKontrol : MonoBehaviour
{
    public Transform firlatmaNoktasi; // Kürelerin fýrlatýlacaðý nokta
    public GameObject kurePrefab; // Küre prefab'i (fýrlatýlacak obje)
    public float atisGucu = 10f; // Fýrlatma gücü
    public float kureOmru = 3f; // Kürenin ömrü (saniye)

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