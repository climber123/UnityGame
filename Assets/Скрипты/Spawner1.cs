using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour {
    public GameObject[] groups;

    private int currentId = 0;
    public void SpawnNext()
    {
        groups[currentId].SetActive(false);
        currentId = Random.Range(0, groups.Length);

        //Instantiate(groups[i], transform.position, Quaternion.identity);
        groups[currentId].SetActive(true);
    }

    // Use this for initialization
    void Start()
    {
        SpawnNext();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
