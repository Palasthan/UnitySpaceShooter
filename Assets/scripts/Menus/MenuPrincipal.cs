﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
  public void startGame()
    {
        SceneManager.LoadScene("Scene_01");
    }
}
