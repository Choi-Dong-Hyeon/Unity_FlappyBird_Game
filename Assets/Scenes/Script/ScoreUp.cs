using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.scoretext += 1;
    }
}
