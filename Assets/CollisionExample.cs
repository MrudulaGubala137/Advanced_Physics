using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        print("Collision Enter");
    }
    public void OnCollisionExit(Collision collision)
    {
        print("Collision Exit");
    }
    public void OnCollisionStay(Collision collision)
    {
        print("Collision Stay");
    }
}
