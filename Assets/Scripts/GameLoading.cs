using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoading : MonoBehaviour
{
	public KeyCode _keyCode = KeyCode.Space;
	public GameObject loadingInfo, loadingIcon;
	private AsyncOperation async;

	IEnumerator Start()
	{
		async = SceneManager.LoadSceneAsync(GameManager.levelName);
		loadingIcon.SetActive(true);
		loadingInfo.SetActive(false);
		yield return true;
		async.allowSceneActivation = false;
		loadingIcon.SetActive(false);
		loadingInfo.SetActive(true);
	}

	void Update()
	{
		if (Input.GetKeyDown(_keyCode)) async.allowSceneActivation = true;
	}
}
