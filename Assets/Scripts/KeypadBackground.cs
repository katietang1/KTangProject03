/*
Name: Katie Tang
Student ID#: 2313452
Chapman email: htang@chapman.edu
Course Number and Section: 236-03
Assignment: Project03 Keypad
This is my own work, and I did not cheat on this assignment.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadBackground : MonoBehaviour
{
    public GameObject UnlockButton;
    public Image BackgroundImage;

    public void HideUnlockButton()
    {
        UnlockButton.SetActive(false);
    }

    public void ChangeToSuccessColor()
    {
        BackgroundImage.color = Color.green;
    }

    public void ChangeToFailColor()
    {
        BackgroundImage.color = Color.red;
    }

    public void ChangeToDefaultColor()
    {
        BackgroundImage.color = Color.grey;
    }
}

