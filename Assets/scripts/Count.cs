using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Count : MonoBehaviour
{
    public static int killed_enemies;
    public TextMeshProUGUI killBox;
     public static string killDisplay;
    // Start is called before the first frame update
    void Start()
    {
        killed_enemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        killDisplay = killed_enemies.ToString("F0");
        killBox.text = killDisplay;
    }
}
