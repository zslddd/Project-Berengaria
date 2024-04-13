using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This is the main class for the game Berengaria.
// Author: zenvunu

public class Berengaria : MonoBehaviour {
    private int FPS = 60; // Target FPS the game should run at, change FPS from 24 only if needed
                          // 60 FPS is needed for the illusion of a PSX / PS1 game (and also for the stability of the game LMAO)
    public static bool isPaused = false;

    void Start() {
        FPSCap();
        Logger.info("Loaded Environment");
    }

    void Update() {

    }

    // FPS Cap
    private void FPSCap() {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = FPS;
        Logger.info("FPS Cap loaded");
    }

    // Pause
    public static void PauseMenu() {
        if (isPaused == true) {
            Time.timeScale = 1;
            isPaused = false;
            Logger.info("Unpaused");
        } else {
            Time.timeScale = 0;
            isPaused = true;
            Logger.info("Paused");
        }
    }



}
