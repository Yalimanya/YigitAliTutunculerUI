using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject bgPanel, habitatPanel, skillsPanel;
    public void OpenBGStoryPanel()
    {
        bgPanel.SetActive(true);
        habitatPanel.SetActive(false);
        skillsPanel.SetActive(false);
    }

    public void OpenHabitatPanel()
    {
        habitatPanel.SetActive(true);
        skillsPanel.SetActive(false);
        bgPanel.SetActive(false);
    }

    public void OpenSkillsPanel()
    {
        skillsPanel.SetActive(true);
        bgPanel.SetActive(false);
        habitatPanel.SetActive(false);
    }
}
