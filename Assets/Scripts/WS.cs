using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WS : MonoBehaviour
{
    private Animator anim;
    public string level;
    public bool DesroyMusic = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnFadeComplete()
    {
        if (DesroyMusic == true)
        {
            FindObjectOfType<AudioManager>().Stop();
        }
        GameManager.levelName = level;
        SceneManager.LoadScene("Loading");
    }
}
