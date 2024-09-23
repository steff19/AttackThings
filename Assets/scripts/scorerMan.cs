using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorerMan : MonoBehaviour
{
    public string score;
    public TextMeshProUGUI  scoreBox;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetString("score");
        scoreBox.text = score;
    }

  
}
