using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    float spinSpeed;
    bool toRotate,stopBtnClicked;
    public ScoreCalculator scoreCalculator;
    public ParticleSystem sprinkleWin;
    bool isParticleAlive = false;

    private void Start()
    {
        toRotate = false;
        bool isParticleAlive = false;
    }

    
    void Update()
    {
        RotateWheel(toRotate);
        StopWheel(toRotate);
    }

    void RotateWheel(bool toRotate)
    {
        if(toRotate)
        {
            transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
        }
            
    }

    void StopWheel(bool toRotate)
    {
        if(!toRotate && stopBtnClicked==true)
        {
            if (spinSpeed >= 0)
            {
                spinSpeed -= Random.Range(100,200)*Time.deltaTime;
                transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
                FindObjectOfType<UIManager>().disableBtns();
            }
            else
            {
                int score= scoreCalculator.CalculateScore(transform);

                if (isParticleAlive)
                {
                    sprinkleWin.Play();
                    isParticleAlive = false;
                }

                FindObjectOfType<UIManager>().ShowStartBtn();
                FindObjectOfType<UIManager>().scoretxt.text ="Score : "+ score.ToString();
            }

        }
    }

    public void enableWheelRotation()
    {
        toRotate = true;
        stopBtnClicked = false;
        spinSpeed = Random.Range(500, 1000);
        FindObjectOfType<UIManager>().ShowStopBtn();
    }

    public void disableWheelRotation()
    {        
        toRotate = false;
        stopBtnClicked = true;
        isParticleAlive=true;
        FindObjectOfType<UIManager>().ShowStartBtn();
    }
}
