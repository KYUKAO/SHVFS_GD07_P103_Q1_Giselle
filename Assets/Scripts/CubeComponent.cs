using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeComponent : MonoBehaviour
{
    float timer;
    float intervalTime = 1f;
    Rigidbody rb;
    bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervalTime)
        {
            timer = 0;
            canMove = true;
        }
    }
    // Update is called once per frame
    void  FixedUpdate()
    {
        if (canMove)
        {
            rb.MovePosition(new Vector3(this.transform.position.x + 2f, this.transform.position.y, this.transform.position.z));
            canMove = false;
        }
      
    }
}
