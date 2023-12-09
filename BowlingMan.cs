using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingMan : MonoBehaviour
{
    public float moveSpeed = 10f; 
    public float _horizontalAxis;
    public float _curHorizontral;
     public float _minPosx, _maxPosX; 
    // Start is called before the first frame update
    void Start()
    {
        _curHorizontral = 0;
    }

    // Update is called once per frame
    void Update()
    {

      _horizontalAxis = Input.GetAxis("Horizontal") * moveSpeed *Time.deltaTime ;
        _curHorizontral -=_horizontalAxis;  
       _curHorizontral = Mathf.Clamp(_curHorizontral,_minPosx, _maxPosX);
       transform.localPosition = new Vector3 (_curHorizontral,transform.localPosition.y,transform.localPosition.z);
      
        
    }
}
