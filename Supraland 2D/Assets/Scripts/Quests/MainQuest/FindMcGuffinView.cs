using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FindMcGuffinView : MonoBehaviour
{
    
    private FindMcGuffin _quest;
    private TextMeshProUGUI _TMP;


    private void Start()
    {
        _quest = FindObjectOfType<FindMcGuffin>(true);
        _TMP = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _TMP.enabled = _quest.IsActive();
    }
}
