using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
