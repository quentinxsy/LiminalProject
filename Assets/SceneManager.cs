using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject largeAtom;
    public GameObject rings;
    public GameObject cluster;
    public GameObject A;
    public GameObject C;
    public GameObject D;
    // Start is called before the first frame update
  
    public void TurnOn()
    {
        cluster.SetActive(true);
        largeAtom.SetActive(true);
        rings.SetActive(true);
        
    }
    public void TurnOff()
    {
        A.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        cluster.SetActive(false);
        largeAtom.SetActive(false);
        rings.SetActive(false);
    }
}
