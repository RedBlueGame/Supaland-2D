using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMcGuffin : MonoBehaviour
{
    public GameObject NextQuest;

    private bool _isActive = false;
    
    public bool IsActive()
    {
        return _isActive;
    }
    public void FinishQuest()
    {
        if (_isActive == true)
        {
            _isActive = false;
            gameObject.SetActive(false);

            if (NextQuest != null)
            {
                NextQuest.SetActive(true);
            }
        }
    }

    private void Start()
    {
        _isActive = true;
    }

}
