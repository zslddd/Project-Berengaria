using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Logger Class
// Prints out anything with a tag.
// Used for debugging

public class Logger : MonoBehaviour {
    public static void info(Object message) {
        Debug.Log("[Berengaria] " + message);
    }

    internal static void info(string v) {
        Debug.Log("[Berengaria] " + v);
    }
}
