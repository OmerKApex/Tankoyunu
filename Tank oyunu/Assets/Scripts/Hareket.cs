using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaKontrol : MonoBehaviour
{
    public float hiz = 10f;
    public float donmeHizi = 90f;
    public float donmeSuresi = 2f; // Dönme süresi (saniye)

    private bool donuyor = false;
    private float donmeBaslangicZamani;
    private float donmeHedefAcisi;

    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatay, 0, dikey) * hiz * Time.deltaTime;
        transform.Translate(hareket);

        if (Input.GetKeyDown(KeyCode.E))
        {
            donmeHedefAcisi += 45f;
            BaslatDonme();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            donmeHedefAcisi -= 45f;
            BaslatDonme();
        }

        if (donuyor)
        {
            float donmeYuzdesi = (Time.time - donmeBaslangicZamani) / donmeSuresi;
            float hedefYavaslamaAcisi = Mathf.LerpAngle(transform.eulerAngles.y, donmeHedefAcisi, donmeYuzdesi);

            transform.eulerAngles = new Vector3(0, hedefYavaslamaAcisi, 0);

            if (donmeYuzdesi >= 1f)
            {
                donuyor = false;
            }
        }
    }

    void BaslatDonme()
    {
        donmeBaslangicZamani = Time.time;
        donuyor = true;
    }
}