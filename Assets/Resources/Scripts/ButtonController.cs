using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    public Button SlygaButton;
    public Button SlameButton;
    public Button SalaweeButton;
    public GameObject Player;
    // Use this for initialization

    void OnEnable()
    {
        print("Enabled");
        SlygaButton.onClick.AddListener(() => Player.GetComponent<SpriteController>().ChangeCharacter("Slyga", "Sythe", "LeafStorm", "LogBlock"));
        SlameButton.onClick.AddListener(() => Player.GetComponent<SpriteController>().ChangeCharacter("Slame", "MagmaToss", "FlameThrower", "Embers"));
        SalaweeButton.onClick.AddListener(() => Player.GetComponent<SpriteController>().ChangeCharacter("Salawee", "WaterSplice", "HydroBlast", "Iceberg"));
    }
    void OnDisable()
    {
        print("Disabled");
        SlygaButton.onClick.RemoveListener(() => Player.GetComponent<SpriteController>().ChangeCharacter("Slyga", "Sythe", "LeafStorm", "LogBlock"));
        SlameButton.onClick.RemoveListener(() => Player.GetComponent<SpriteController>().ChangeCharacter("Slame", "MagmaToss", "LeafStorm", "LogBlock"));
        SalaweeButton.onClick.RemoveListener(() => Player.GetComponent<SpriteController>().ChangeCharacter("Salawee", "WaterSplice", "HydroBlast", "Iceberg"));
    }
}
