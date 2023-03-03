using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeMake : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float timer = 0;
    [SerializeField] float diff=1;
    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer > diff)
        {
        GameObject pipeposition = Instantiate(pipe);
            pipeposition.transform.position = new Vector3(9, Random.Range(-2f,3f), 0);
            timer = 0;
            Destroy(pipeposition,10f);
        }
        
    }
}
