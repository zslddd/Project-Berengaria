using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Key Input API
// Checks if a key is pressed, and triggers the keybind
// Author: zenvunu

public class KeyInput : MonoBehaviour {
    void Start() {
        Logger.info("KeyInput API loaded");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Berengaria.PauseMenu();
        }
    }
}
