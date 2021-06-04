using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField] int x = 0;
    [SerializeField] int y = 0;
    [SerializeField] int z = 0;
    [SerializeField] int Velocidad = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x * Time.deltaTime * Velocidad, y * Time.deltaTime * Velocidad,
            z * Time.deltaTime * Velocidad);
        
    }
}
