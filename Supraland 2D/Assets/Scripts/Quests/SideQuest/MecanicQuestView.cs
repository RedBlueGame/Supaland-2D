using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MecanicQuestView : MonoBehaviour
{
    private MecanicQuest _quest;
    private TextMeshProUGUI _TMP;


    private void Start()
    {
        _quest = FindObjectOfType<MecanicQuest>(true);
        _TMP = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _TMP.enabled = _quest.IsActive();
        _TMP.text = _quest.GetProgressReport();
    }
    
    
}
