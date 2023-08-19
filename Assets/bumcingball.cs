using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumcingball : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D body;
    public Vector2 speed;
    void Start()
    {
        body.velocity=speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
