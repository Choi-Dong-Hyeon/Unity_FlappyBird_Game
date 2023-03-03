using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static  int scoretext=0;
    public static int bestScoretext = 0;

    public static TextMeshProUGUI  score;
        
    void Start()
    {
        scoretext = 0;
    }

  
    void Update()
    {
        score = GetComponent<TextMeshProUGUI>();
        //score.text = score.text.ToString();
        score.text = scoretext.ToString();

        Debug.Log(score.text);
    }
}
