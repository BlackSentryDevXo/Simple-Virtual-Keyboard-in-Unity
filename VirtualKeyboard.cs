using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class VirtualKeyboard : MonoBehaviour 
{
    public static VirtualKeyboard instance;

    public TMP_InputField inputField;
    public List<string> alphabets;

    public GameObject letterPrefab; 
    public Transform letterHolder;

    private void Awake() {
        instance = this;
    }

    private void Start() 
    {
        foreach (var letter in alphabets)
        {
            GameObject _letterObj = Instantiate(letterPrefab, letterHolder, false);
            _letterObj.name = letter;
            VirtualLetter newLetter = _letterObj.GetComponent<VirtualLetter>();
            newLetter.textObj.text = letter;
        }
    }

    public void CheckLetter(string letterToCheck)
    {
        inputField.text += letterToCheck;
        //check letter functions
    }
}