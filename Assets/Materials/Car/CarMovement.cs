using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public GameObject Carfab;
    public Transform CarStart;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CarGeneration());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator CarGeneration()
    {
        while (true)
        {
            int random = Random.Range(0, 5);
            if(random < 1)
            {
                Instantiate(Carfab, CarStart.position, CarStart.transform.rotation, transform);
            }
            yield return new WaitForSeconds(Random.Range(0f, 1f) + 0.5f);
        }
    }
}
