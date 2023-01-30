using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xVal = 0f;
    [SerializeField] float yVal = 1f;
    [SerializeField] float zVal = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xVal, yVal, zVal);
    }
}
