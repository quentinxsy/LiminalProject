using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sadsadad : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawn");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawn()
    {
        yield return new WaitForSeconds(45f);
        explosion.SetActive(true);


    }

    public void SpawnExplosion()
    {

    }
}