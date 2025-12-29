using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MucGiffin : MonoBehaviour
{
    public GameObject AmmoPrephab;
    public GameObject UltaPrephab;
    public float Cooldown;
    public float UltaCooldown;
    public float AmmoSpeed;
    public int AmmoDamage;
    public float UltaSpeed;
    public int UltaDamage;
    public GameObject LightPanel;

    private float _timer;
    private float _ultaTimer;
    private bool _hasUlt;

   public void UnlockUlt()
    {
        _hasUlt = true;
    }
    void Start()
    {
        _hasUlt = false;
    }

    
    void Update()
    {
        _timer -= Time.deltaTime;

        if (Input.GetMouseButton(0) && (_timer < 0))
        {
            NormalAttack();
        }

        _ultaTimer -= Time.deltaTime;

        if ((_hasUlt == true) && Input.GetMouseButton(1) && (_ultaTimer < 0))
        {
            UltimateAttack();
        }
    }
    private void NormalAttack()
    {
        GameObject fly;
        fly = Instantiate(AmmoPrephab, transform.position, transform.rotation);
        Destroy(fly, 15);
        fly.GetComponent<Ammo>().Speed = AmmoSpeed * transform.lossyScale.x;
        fly.GetComponent<Ammo>().Damage = AmmoDamage;
        _timer = Cooldown;

        LightPanel.GetComponent<Image>().fillAmount = Mathf.InverseLerp(Cooldown, 0, _timer);
    }
    private void UltimateAttack()
    {
        GameObject ult;
        ult = Instantiate(UltaPrephab, transform.position, transform.rotation);
        Destroy(ult, 10);
        ult.GetComponent<MucGuffinUlta>().Speed = UltaSpeed * transform.lossyScale.x;
        ult.GetComponent<MucGuffinUlta>().Damage = UltaDamage;
        _ultaTimer = UltaCooldown;
    }
}
