﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawingScreen : MonoBehaviour
{
    public void GoToHome ()
    {
        SceneManager.LoadScene(0);
    }
}
