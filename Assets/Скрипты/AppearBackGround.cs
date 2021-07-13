using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearBackGround : MonoBehaviour {

    
    private float groundHorizontalLength;		
    [SerializeField] private Spawner spawner;
    
    private void Awake()
    {
        
        groundHorizontalLength = 19.7f;
    }
    
    private void Update()
    {
        if (transform.position.x < -groundHorizontalLength - 3f)
        {
            RepositionBackground();
        }
    }
    
    private void RepositionBackground()
    {
        
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f + 2.9f, 0);
        
        transform.position = (Vector2)transform.position + groundOffSet;

        spawner.SpawnNext();
        
    }
}
