using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Sprite characterSprite;
    public GameObject weapon;
    public PlayerStats stats;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Pressed");
            if(weapon != null)
            {
                weapon.GetComponent<MeleeWeapon>().Attack();
            }
        }
    }
}
