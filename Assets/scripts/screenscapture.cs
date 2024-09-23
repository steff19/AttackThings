using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenscapture : MonoBehaviour
{
   int count = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        ScreenCapture.CaptureScreenshot($"/Users/stefanmcdonald/Desktop/screenshot-{count++}.png");
    }
}
