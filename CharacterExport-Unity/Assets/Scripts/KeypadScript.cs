using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadScript : MonoBehaviour
{
    public string password;
    public string enteredPW;
    public TMP_Text passwordDisplay;
    public int passInt;

    public GameObject stand;
    public GameObject escapePod;
    public Camera cutsceneCamera;
    public Camera mainCamera;
    //public GameObject VCAM;



    // Start is called before the first frame update
    void Start()
    {
        passInt = password.Length;
        passwordDisplay.text = "Enter Passcode";
    }

    // Update is called once per frame
    void Update()
    {
        if (enteredPW.Length == password.Length)
        {
            if (enteredPW == password)
            {
                passwordDisplay.text = "Correct Passcode";

                //MAKE STUFF HAPPEN
                //VCAM.SetActive(false);
                mainCamera.enabled = false;
                
                cutsceneCamera.enabled = true;
                this.gameObject.SetActive(false);
                Destroy(stand);
                escapePod.GetComponent<BoxCollider>().enabled = false;
            }
            else
            {
                passwordDisplay.text = "Wrong Passcode";
                enteredPW = "";
            }
        }
    }

    public void ButtonNumber(string btnNum)
    {
        Debug.Log(btnNum);
        EnterCode(btnNum);
    }

    public void EnterCode(string keyEntered)
    {
        enteredPW += keyEntered;
        passwordDisplay.text = enteredPW;
    }

}
