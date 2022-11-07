using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]GameObject StartBtn,StopBtn;
    public TextMeshProUGUI scoretxt;

    private void Start()
    {
        ShowStartBtn();
    }

    public void ShowStartBtn()
    {
        StartBtn.SetActive(true);
        StopBtn.SetActive(false);
    }

    public void ShowStopBtn()
    {
        StartBtn.SetActive(false);
        StopBtn.SetActive(true);
    }

    public void disableBtns()
    {
        StartBtn.SetActive(false);
        StopBtn.SetActive(false);
    }
    


}
