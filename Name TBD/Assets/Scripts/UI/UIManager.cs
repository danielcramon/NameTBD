using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryPanel;
    [SerializeField] GameObject equipmentPanel;
    [SerializeField] GameObject ItemPanel;
    bool inventoryPanelActive;
    bool equipmentPanelActive;
    // Start is called before the first frame update
    void Start()
    {
        inventoryPanelActive = false;
        equipmentPanelActive = false;

        inventoryPanel.SetActive(false);
        equipmentPanel.SetActive(false);
        DeactivateItemPanel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryPanelActive)
            {
                inventoryPanel.SetActive(false);
                inventoryPanelActive = false;
            }
            else
            {
                inventoryPanel.SetActive(true);
                inventoryPanelActive = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (equipmentPanelActive)
            {
                equipmentPanel.SetActive(false);
                equipmentPanelActive = false;
            }
            else
            {
                equipmentPanel.SetActive(true);
                equipmentPanelActive = true;
            }
        }
    }

    public void ActivateItemPanel()
    {
        ItemPanel.SetActive(true);
    }

    public void DeactivateItemPanel()
    {
        ItemPanel.SetActive(false);
    }
}
