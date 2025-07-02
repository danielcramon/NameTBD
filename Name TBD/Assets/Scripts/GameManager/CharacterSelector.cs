using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] List<GameObject> characters;
    public GameObject character;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void PickCharacter(int index)
    {
        character = characters[index];
    }
}
