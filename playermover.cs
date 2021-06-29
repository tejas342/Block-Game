using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed ;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed ;
        transform.Translate(x,0,z);
    }
}
