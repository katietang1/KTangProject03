using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Name: Katie Tang
Student ID#: 2313452
Chapman email: htang@chapman.edu
Course Number and Section: 236-03
Assignment: Project03 Keypad
This is my own work, and I did not cheat on this assignment.
*/
public class KeypadButton : MonoBehaviour
{
    public int ButtonValue;
    public Keypad Keypad;

    public void OnClick()
    {
        Keypad.RegisterButtonClick(ButtonValue);
       
    }
}
