using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Oscillate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Oscillate()
    {
        //float speed = Time.deltaTime * 5f;
        for(float i= 0; i < 60; i += Time.deltaTime*5f)
        {
            transform.position += new Vector3(0f, 0f, Time.deltaTime*5f);
            yield return null;
        }
        for (float i = 0; i < 60; i += Time.deltaTime * 5f)
        {
            transform.position -= new Vector3(0f, 0f, Time.deltaTime * 5f);
            yield return null;
        }
    }
}
