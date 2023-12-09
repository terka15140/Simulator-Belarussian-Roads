using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{    public GameObject [] _spawnObj;
    public float spawnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",1f ,spawnSpeed);
        
    }

    // Update is called once per frame
    void Spawn()
    {
        int randomValue = Random.Range(0, _spawnObj.Length);
        GameObject gm =  Instantiate(_spawnObj[randomValue], new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity);
       
        
    }
}
