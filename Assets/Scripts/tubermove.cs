using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubermove : MonoBehaviour
{
    [SerializeField] public float speedtuber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    private void move()
    {
        transform.position += Vector3.left * speedtuber * Time.deltaTime;
    }
}
