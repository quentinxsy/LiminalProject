using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    { 
        Destroy(other.gameObject);
        Destroy(gameObject);
        Debug.Log("The fk");
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        e.SetActive(true);
        f.SetActive(true);
    }
}
