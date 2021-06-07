using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartController : MonoBehaviour
{

    private float speed = 10f;
    private float rotate = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotate;

        move *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, rotation, 0); 

    }
}
