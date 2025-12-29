using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoToBluevilleView : MonoBehaviour
{
    private GoToBlueville _quest;
    private TextMeshProUGUI _TMP;


    private void Start()
    {
        _quest = FindObjectOfType<GoToBlueville>(true);
        _TMP = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
       _TMP.enabled = _quest.IsActive();
    }
}