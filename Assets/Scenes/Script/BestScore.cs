using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Best Score: " + Score.bestScoretext;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
