using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTriggerDebug : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    [SerializeField] ItemGenerator itemGenerator;
    [SerializeField] bool trigger;
    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            uiManager.ActivateItemPanel();
            itemGenerator.ChooseItems();

            trigger = false;
        }
    }
}
