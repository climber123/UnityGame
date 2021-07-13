using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Transform target;
    public BoxCollider2D left;
    public BoxCollider2D bottom;


    private void Start()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(0,0));
        Vector3 size = left.size;
        Vector3 size_b = bottom.size;
        left.transform.position = new Vector3(pos.x - size.x/2, pos.y + size.y/2.5f, pos.z);
        bottom.transform.position = new Vector3(pos.x + size_b.x / 2.5f, pos.y - size_b.y / 2, pos.z);
    }

    // Update is called once per frame
    void Update () {
        float positionX = Mathf.Max(target.position.x, -15f);

        transform.position = new Vector3(positionX,
            transform.position.y,
            transform.position.z);
        
	}
}
