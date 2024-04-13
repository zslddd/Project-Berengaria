using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashWait : MonoBehaviour {
    private float holdTime = 3.0f; // Time to hold the key down
    private float heldTimer = 0.0f;
    private bool isKeyHeld = false;

    void Start() {
        Cursor.visible = false;
        StartCoroutine(WaitAndLoadScene());
    }

    void Update() {
        if (Input.anyKeyDown) {
            isKeyHeld = true;
            heldTimer = 0.0f; // Restart the timer
        }

        if (isKeyHeld) {
            heldTimer += Time.deltaTime;

            if (heldTimer >= holdTime) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                SceneManager.UnloadSceneAsync("Splash");
                isKeyHeld = false; // Reset for future holds
            }
        }
    }

    IEnumerator WaitAndLoadScene() {
        yield return new WaitForSeconds(50f);
        Logger.info("Started Timer");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.UnloadSceneAsync("Splash");
    }
}