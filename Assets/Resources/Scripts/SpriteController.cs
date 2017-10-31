using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour {
    public Sprite sprite;
 
    public void ChangeCharacter(string PokemonName, string MovesetOne, string MovesetTwo, string MovesetThree)
    {
        gameObject.GetComponent<PlayerController>().AttackOne = MovesetOne;
        gameObject.GetComponent<PlayerController>().AttackTwo = MovesetTwo;
        gameObject.GetComponent<PlayerController>().AttackThree = MovesetThree;
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Pokemon/" + PokemonName + "/" + PokemonName);
        foreach (Transform child in transform)
        {
            if (child.name == PokemonName + "Collider" || child.name == "Spotlight")
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
