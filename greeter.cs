using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greeter : MonoBehaviour
{
    private int frame = 0;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Hola! soy " + gameObject.name + "."); 
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(gameObject.name + " frame: " + frame);
      frame++;
    }
}

