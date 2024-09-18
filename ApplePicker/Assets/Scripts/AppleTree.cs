using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    //prefab for instantiating apples
    public GameObject applePrefab;
    //speed at which appleTree moves
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.1f;
    public float appleDropDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //start dropping apples
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;


        //changing direction
        if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // move right
        }
        else if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }  
    } 
    private void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        GameObject Apple1 = Instantiate<GameObject>(applePrefab);
        Apple1.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }
}  
