using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static string levelName;
    void Awake()
    {
        Instance = this;
    }
}
