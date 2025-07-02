using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] int id;
    [SerializeField] int level;
    [SerializeField] int levelCap;
    [SerializeField] string title;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] int cost;
    [SerializeField] string currencyName;

    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI descriptionText;
    [SerializeField] TextMeshProUGUI costText;

    [SerializeField] int[] unlockedSkills;
    [SerializeField] int[] unlockedConnections;
    [SerializeField] int unlockLevel;


    public void Buy()
    {
        if(TechTree.Instance.skillPoints >= cost && level != levelCap)
        {
            AddLevel();
            TechTree.Instance.UseSkillPoint(cost);
        }
        TechTree.Instance.UpdateAllUISkills();
    }

    public void AddLevel()
    {
        level++;
        if(level == unlockLevel)
        {
            foreach(int skillID in unlockedSkills)
            {
                TechTree.Instance.activeSkills.Add(skillID);
            }
            TechTree.Instance.SetVisableSkills();
            foreach (int skillID in unlockedConnections)
            {
                TechTree.Instance.activeConnectors.Add(skillID);
            }
            TechTree.Instance.SetVisableConncetors();
        }
    }

    public void SetVisable()
    {
        gameObject.SetActive(true);
    }

    public void UpdateUI()
    {
        titleText.text = $"{level}/{levelCap}\n{title}";
        descriptionText.text = description;
        costText.text = cost + " " + currencyName;
    }
}
