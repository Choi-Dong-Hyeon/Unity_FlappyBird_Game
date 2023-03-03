using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] float pipeSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left* pipeSpeed * Time.deltaTime;
        
    }
}
