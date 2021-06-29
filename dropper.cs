using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody Rbody;
    [SerializeField] int countertime = 4;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        Rbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        Rbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > countertime)
        {
            renderer.enabled = true;
            Rbody.useGravity = true;
        }
    }
}
