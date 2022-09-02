using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class VirtualLetter : MonoBehaviour 
{
    public TMP_Text textObj;

    public void OnLetterClick() {
        VirtualKeyboard.instance.CheckLetter(textObj.text);
        Debug.Log("we clicked on letter " + this.gameObject.name);
    }
}