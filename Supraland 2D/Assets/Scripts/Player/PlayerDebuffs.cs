using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDebuffs : MonoBehaviour
{
    
    public Image Image;
    public float CoolDown;

    private float _deltaA;
    private float _currentA;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ClearDebuffs()
    {


        _deltaA = 0;
        _currentA = 0;
        Image.color = new(0f, 0f, 0f, _currentA);
    }


    private void Update()
    {
        _timer -= Time.deltaTime;

        if (((_deltaA < 0) && (_currentA > 0))  || ((_deltaA > 0) && (_currentA < 1)))
        {
            _currentA += _deltaA * Time.deltaTime;
            Image.color = new(0f, 0f, 0f, _currentA);
        }
       

        if (_timer < 0)
        {
            _deltaA = -1;
            //_currentA = 1;
        }
    }

    // Update is called once per frame
    public void BecomeBlind()
    {
       // if (IsActive == true)
        
            _deltaA = 1;
        
        _timer = CoolDown;
    }
}
