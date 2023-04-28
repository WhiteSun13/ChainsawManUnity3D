using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private Animator anim; 
    private bool EnterPressed = false;
    private MenuImage imageMM;
    
    public GameObject ImageMenu;
    public GameObject MenuSaw;

    public Vector3 imgPos;
    public Camera pochitaBG;
    public Color ColorBG;
    public KeyCode _keyCode = KeyCode.Return;

    void Start()
    {
        anim = GetComponent<Animator>();
        imageMM = ImageMenu.GetComponent<MenuImage>();
    }

    void Update()
    {
        if (Input.GetKeyDown(_keyCode) && EnterPressed == false)
        {
            anim.Play("PressEnter");
            if (imageMM != null)
            {
                imageMM.SetImgPos(new Vector3(-480, -1085, 0));
            }
            if (MenuSaw != null)
            {
                MenuSaw.SetActive(true);
            }
            EnterPressed = true;
        }
    }
    
    public void Hover()
    {
        pochitaBG.backgroundColor = ColorBG;
        imageMM.SetImgPos(imgPos);
    }
}
