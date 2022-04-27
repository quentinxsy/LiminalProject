using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float turn;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turnSpeed = turn * 90 * Time.deltaTime;
        transform.Rotate(0, turnSpeed, 0);

        float moveSpeed = speed * 120 * Time.deltaTime;
        transform.Translate(0, 0, moveSpeed);
    }
}
