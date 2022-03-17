using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSystem : Singleton<TimerSystem>
{
    float timer;
    float intervalTime = 1.5f;
    GameObject cube;
    public Transform TargetPos;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        cube = Resources.Load("Cube") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervalTime)
        {
            Instantiate(cube, TargetPos);
            timer = 0;
        }
    }
}
