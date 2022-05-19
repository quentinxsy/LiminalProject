using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge : MonoBehaviour
{
    public MeshRenderer atom;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    void OnBecameVisible()
    {
        //atom.enabled = true;
    }

    void OnBecameInvisible()
    {
        //atom.enabled = false;
    }
}
