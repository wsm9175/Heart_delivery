using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{

    public GameObject coverImage;
    public GameObject canvasRec;
    public GameObject canvasMenuKor;
    public GameObject canvasMenuUSA;
    public GameObject canvasMenuITA;
    public GameObject canvasMenuFRN;
    public GameObject ARSessionOrigin2;
    public GameObject ARSessionOrigin1;
    public GameObject canvasShoot;
    public GameObject canvasboxes;
    public GameObject canvasExit;
    // Start is called before the first frame update
    void Start()
    {
        coverImage.SetActive(true);
        ARSessionOrigin2.SetActive(false);
        canvasMenuKor.SetActive(false);
        canvasMenuUSA.SetActive(false);
        canvasMenuITA.SetActive(false);
        canvasMenuFRN.SetActive(false);
        canvasShoot.SetActive(false);
        ARSessionOrigin1.SetActive(false);
        canvasboxes.SetActive(false);
        canvasExit.SetActive(false);
        canvasRec.SetActive(false);
    }

    public void OnclickStartButton() {
        ARSessionOrigin1.SetActive(true);
        canvasRec.SetActive(true);
        coverImage.SetActive(false);
    }

    public void OnclickButton()
    {
        ARSessionOrigin1.SetActive(false);
        canvasRec.SetActive(false);
        canvasMenuKor.SetActive(false);
        canvasMenuUSA.SetActive(false);
        canvasMenuITA.SetActive(false);
        canvasMenuFRN.SetActive(false);
        canvasboxes.SetActive(true);
    }

    public void onClickOK()
    {
        canvasShoot.SetActive(true);
        canvasboxes.SetActive(false);
        ARSessionOrigin2.SetActive(true);
    }

    public void OnclickEndDeliver()
    {
        canvasShoot.SetActive(false);
        ARSessionOrigin2.SetActive(false);
        canvasExit.SetActive(true);
    }

    public void OnclickExit()
    {
        Application.Quit();
    }
}
