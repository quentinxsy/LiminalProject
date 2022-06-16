using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("move");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator move()
    {
        yield return new WaitForSeconds(50f);
        this.GetComponent<Spin>().enabled = true;
        yield return new WaitForSeconds(56f);
        this.GetComponent<Spin>().enabled = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "blackhole")
        {
            //SceneManager.LoadScene("Menu");
        }
    }
}
