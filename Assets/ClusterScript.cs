using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterScript : MonoBehaviour
{
    public GameObject largeAtom;
    public GameObject rings;
    public GameObject cluster;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TurnOn()
    {
        cluster.SetActive(true);
        largeAtom.SetActive(true);
        rings.SetActive(true);
    }



}
