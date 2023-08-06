using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YonVerme : MonoBehaviour
{
    public float xRotation = 0.0f;
    public float mauseSensivity = 100f;
    public GameObject oyuncu;

    // Update is called once per frame
    void Update()
    {
        float mauseX = Input.GetAxis("Mause X ") * Time.deltaTime * mauseSensivity;
        float mauseY = Input.GetAxis("Mause Y ") * Time.deltaTime * mauseSensivity;

        xRotation += mauseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        oyuncu.transform.Rotate(Vector3.up * mauseX);















    }
}
