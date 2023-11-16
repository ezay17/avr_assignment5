using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 50f;
    
        void Update()
        {
            // Rotiere die Kugel um die Y-Achse basierend auf der Geschwindigkeit
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
}
