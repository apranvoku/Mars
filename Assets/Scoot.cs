using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(transform.gameObject, 12f);
        StartCoroutine(Run());
    }

    public IEnumerator Run()
    {
        for (float i = 0; i < 60; i += Time.deltaTime * 5f)
        {
            transform.position += new Vector3(0f, 0f, Time.deltaTime * 5f);
            yield return null;
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
