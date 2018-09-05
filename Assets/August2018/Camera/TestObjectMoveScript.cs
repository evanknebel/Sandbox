using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjectMoveScript : MonoBehaviour
{
    float timeCounter;
    //Rigidbody rb;
    float radius;
    Vector3 centerpoint;
    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        timeCounter += Time.deltaTime;
        float x = Mathf.Cos(timeCounter) * 2;
        float y = Mathf.Sin(timeCounter) * 2;
        float z = 0;
        //centerpoint = new Vector3(0, 1, 0);
        transform.position = new Vector3(x, y, z);
    }
}
