using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveblePlatform : MonoBehaviour
{
    public float speed; 
    public float destroyTime;
    
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
