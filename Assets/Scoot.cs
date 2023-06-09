using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoot : MonoBehaviour
{
    public const float TIME_TO_EXPLOSION = 8.0f;
    public const float CAR_ENERGY = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(transform.gameObject, TIME_TO_EXPLOSION);
        StartCoroutine(Run());
    }

    public IEnumerator Run()
    {

        for (float i = 0; i < TIME_TO_EXPLOSION; i += Time.deltaTime)
        {
            transform.position += transform.parent.forward * Time.deltaTime * CAR_ENERGY;
            yield return null;
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
