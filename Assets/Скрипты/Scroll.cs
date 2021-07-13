using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float start_speed = 0.9f;
    public float max_speed = 3.0f;
    public float accelerate_time = 250f;
    private Rigidbody2D rdb123;
	// Use this for initialization
	void Start () {
        rdb123 = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        rdb123.velocity = Vector2.left * (start_speed + Mathf.Min(Time.time / accelerate_time, max_speed - start_speed));
        
    }
}
