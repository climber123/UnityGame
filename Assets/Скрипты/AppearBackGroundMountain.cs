using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearBackGroundMountain : MonoBehaviour {

    private float groundHorizontalLength;
    [SerializeField] private Spawner1 spawner1;

    private void Awake()
    {
        groundHorizontalLength = 19.7f;
    }

    private void Update()
    {
        if (transform.position.x < -groundHorizontalLength - 15f)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {

        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f + 2.9f, 0);

        transform.position = (Vector2)transform.position + groundOffSet;

        if (spawner1 != null)
            spawner1.SpawnNext();

    }
}
