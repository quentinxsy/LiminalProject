using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabOnClick : MonoBehaviour
{
    public GameObject SFX;
    public int RayDistance = 10;
    private Vector3 Point;
    public LayerMask Atom;

    public float spawnCd ;
    private float nextClickTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextClickTime && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, Atom.value))
            {
                
                Point = hit.point;
                Instantiate(SFX, Point, Quaternion.identity);

                nextClickTime = Time.time + spawnCd;
            }
        }
    }
}

