using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
	public float fireRate;
	public string levelToLoad;
	public KeyCode _keyCode = KeyCode.Space;

	void Start()
	{
		Invoke("LOL", fireRate);
	}
	void Update()
    {
		if (Input.GetKeyDown(_keyCode)) SceneManager.LoadScene(levelToLoad);
	}
	void LOL()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}
