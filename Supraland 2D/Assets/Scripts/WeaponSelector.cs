using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{

    public GameObject Sword;
    public GameObject MucGiffin;
    public GameObject ForceBean;
    public GameObject MucGiffinButton;
    public GameObject ForceBeanButton;
    public GameObject SwordLightPanel;
    public GameObject MucGiffinLightPanel;
    public GameObject ForceBeanLightPanel;
    public bool HasMucGiffin;
    public bool HasForceBeam;

    // Start is called before the first frame update
    void Start()
    {
        Sword.SetActive(true);
        MucGiffin.SetActive(false);
        ForceBean.SetActive(false);
        SwordLightPanel.SetActive(true);
        MucGiffinLightPanel.SetActive(false);
        ForceBeanLightPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MucGiffinButton.SetActive(HasMucGiffin);
        ForceBeanButton.SetActive(HasForceBeam);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Sword.SetActive(true);
            MucGiffin.SetActive(false);
            ForceBean.SetActive(false);
            SwordLightPanel.SetActive(true);
            MucGiffinLightPanel.SetActive(false);
            ForceBeanLightPanel.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && (HasMucGiffin == true))
        {
            Sword.SetActive(false);
            MucGiffin.SetActive(true);
            ForceBean.SetActive(false);
            SwordLightPanel.SetActive(false);
            MucGiffinLightPanel.SetActive(true);
            ForceBeanLightPanel.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && (HasForceBeam == true))
        {
            Sword.SetActive(false);
            MucGiffin.SetActive(false);
            ForceBean.SetActive(true);
            SwordLightPanel.SetActive(false);
            MucGiffinLightPanel.SetActive(false);
            ForceBeanLightPanel.SetActive(true);
        }
    }
}
