using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void NewGame()
    {
        SceneManager.LoadScene("DarkRocks");

    }
	// Update is called once per frame
	void Update () {
		
	}
}
