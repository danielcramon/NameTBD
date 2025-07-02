using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TechTree : MonoBehaviour
{
    public static TechTree Instance;
    [SerializeField] List<Skill> skills;
    public List<int> activeSkills;

    [SerializeField] List<GameObject> connectors;
    public List<int> activeConnectors;

    [SerializeField] TextMeshProUGUI skillPointsText;
    public int skillPoints;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        UpdateAllUISkills();
        UseSkillPoint(0);
    }

    public void SetVisableSkills()
    {
        foreach (int skillID in activeSkills)
        {
            skills[skillID].SetVisable();
        }   
    }

    public void SetVisableConncetors()
    {
        foreach (int skillID in activeConnectors)
        {
            connectors[skillID].SetActive(true);
        }
    }

    public void UpdateAllUISkills()
    {
        foreach(Skill skill in skills)
        {
            skill.UpdateUI();
        }
    }

    public void UseSkillPoint(int cost)
    {
        skillPoints -= cost;
        skillPointsText.text = "Skill Points: " + skillPoints;
    }
}
