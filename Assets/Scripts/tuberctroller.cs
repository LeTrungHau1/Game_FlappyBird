using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuberctroller : MonoBehaviour
{
    public GameObject tuberprefab;
    private float countdown;
    public float timeduration;

    public bool enabletuber;

    // Start is called before the first frame update
    void Start()
    {
        countdown = timeduration;
        enabletuber = false;
    }

    // Update is called once per frame
    void Update()
    {
        appear();
    }
    public void appear()
    {
        if (enabletuber == true)
        {
            countdown -= Time.deltaTime; //dếm ngược thời gian
            if (countdown < 0)
            {
                Instantiate(tuberprefab, new Vector3(2, Random.Range(-4f, 1.7f), 0), Quaternion.identity);
                countdown = timeduration;
            }
        }
    }
}
