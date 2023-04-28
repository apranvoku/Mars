using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public GameObject Carfab;
    public Transform CarStart1;
    public Transform CarStart2;
    public Transform CarStart3;
    public Transform CarStart4;
    public Transform CarStart5;
    public List<Transform> locations;

    // Start is called before the first frame update
    void Start()
    {
        locations.Add(CarStart1);
        locations.Add(CarStart2);
        locations.Add(CarStart3);
        locations.Add(CarStart4);
        locations.Add(CarStart5);

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
            Instantiate(Carfab, locations[Random.Range(0, 5)].position, Quaternion.identity, transform.parent);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
