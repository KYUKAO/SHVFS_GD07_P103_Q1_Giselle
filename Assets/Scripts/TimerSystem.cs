using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSystem : Singleton<TimerSystem>
{
    float timer;
    float intervalTime = 1f;
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervalTime)
        {
            Debug.Log("A message");
            timer = 0;
        }
    }
}
