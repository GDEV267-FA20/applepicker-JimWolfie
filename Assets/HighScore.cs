﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    // Start is called before the first frame update
    void Start()
    {
        var gt = this.GetComponent<TextMeshProUGUI>();
        gt.text = "High Score: " +score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
