using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class Delay : MonoBehaviour
{
    public GameObject blackhole;
    public GameObject lightTrial;
    
    
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
        yield return new WaitForSeconds(.5f);
        blackhole.SetActive(true);
        yield return new WaitForSeconds(3f);
        lightTrial.SetActive(true);
        


    }
}
