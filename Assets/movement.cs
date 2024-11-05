using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cat is falling");
    }

    void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        Debug.Log(dir);
        rb.velocity = dir * 20; 

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
