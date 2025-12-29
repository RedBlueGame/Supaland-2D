using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicQuest : MonoBehaviour
{
    private int _totalScrap;
    private bool _isActive = false;
    private int _scrap;

    public bool IsActive()
    {
        return _isActive;
    }

    public bool IsAllScrapCollected()
    {
        if ((_scrap == _totalScrap) && (_scrap > 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetProgressReport()
    {

        if (_scrap == _totalScrap)
        {
            return "Come back to mecanic and collect your upgrade";
        }

        else
        {
            return "Bring scrap and bring it to mecanic :" + _scrap + "/" + _totalScrap;
        }
    }

    public void AddProgress()
    {
        _scrap += 1;
    }

    public void FinishQuest()
    {  
        if (_isActive == true)
        {
            _isActive = false;
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        _isActive = true;
        MecanicQuestProgress[] mecanicQuestProgresses = FindObjectsOfType<MecanicQuestProgress>(true);
        foreach (MecanicQuestProgress gears in mecanicQuestProgresses)
        {
            gears.gameObject.SetActive(true);
          _totalScrap = mecanicQuestProgresses.Length;
        }
    }
}