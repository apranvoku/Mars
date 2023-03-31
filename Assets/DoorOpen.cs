using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(OpenDoor());
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator OpenDoor()
    {
        for(float i = 0; i < 5f; i+=Time.deltaTime)
        {
            transform.Rotate(new Vector3(0f, Time.deltaTime * 18f, 0f));
            yield return null;
        }
    }
}
