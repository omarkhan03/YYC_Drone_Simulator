using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Update() {
        if (Input.GetButton("SG")) {
            StartGame();
        }
    }

    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}
