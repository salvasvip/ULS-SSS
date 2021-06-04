using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictimCount : MonoBehaviour
{
    [SerializeField] Text cantidadVictimas;
    public int victimas = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        cantidadVictimas.text = victimas.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        cantidadVictimas.text = victimas.ToString();
        
    }
}
