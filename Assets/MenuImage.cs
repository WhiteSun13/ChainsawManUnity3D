using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuImage : MonoBehaviour
{
    public Vector3 imgPos;
    private RectTransform imageMM;

    void Start()
    {
        imageMM = GetComponent<RectTransform>();
    }

    void Update()
    {
        imageMM.localPosition = Vector3.MoveTowards(imageMM.localPosition, imgPos, 30f);
    }

    public void SetImgPos(Vector3 a)
    {
        imgPos = a;
    }
}
