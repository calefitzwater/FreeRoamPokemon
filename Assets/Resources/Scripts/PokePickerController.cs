using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokePickerController : MonoBehaviour {
    public static bool pokePicker;
    public Canvas GUICanvas;

	void OnTriggerEnter2D (Collider2D collider) {
        if (collider.tag == "Player")
        {
            StartPokePicker();;
        }
	}

    public void StartPokePicker()
    {
        pokePicker = true;
        GUICanvas.gameObject.SetActive(true);
    }
    public void EndPokePicker()
    {
        pokePicker = false;
        GUICanvas.gameObject.SetActive(false);
    }
}
