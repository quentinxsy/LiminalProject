using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float rotateX;
    [SerializeField] private float rotateY;
    [SerializeField] private float rotateZ;
   
    [SerializeField] private float moveX;
    [SerializeField] private float moveY;
    [SerializeField] private float moveZ;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        float RX = rotateX * Time.deltaTime;
        float RY = rotateY * Time.deltaTime;
        float RZ = rotateZ * Time.deltaTime;
        transform.Rotate(RX, RY, RZ);

        float MX = moveX * Time.deltaTime;
        float MY = moveY * Time.deltaTime;
        float MZ = moveZ * Time.deltaTime;
        transform.Translate(MX, MZ, MY);
    }


    public void activate()
    {

    }
}
