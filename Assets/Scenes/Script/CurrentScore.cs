using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text ="Score: " + Score.scoretext.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
