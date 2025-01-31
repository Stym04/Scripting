using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        int vidas = 1;
        int level = 5;
        vidas += level;
        // Ahora hacemos que se mande a la consola
        print(vidas);

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5.5f;
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
