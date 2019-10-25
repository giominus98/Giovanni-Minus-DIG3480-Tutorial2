﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public Text HungerText;
    public Text FriendshipText;
    public Text IsSickText;

    public GameObject Rock;

    // Start is called before the first frame update
    void Start()
    {
        /*HungerText.text = "I'm hungry";
        FriendshipText.text = "Hello";
        IsSickText.text = "Healthy";*/
    }

    // Update is called once per frame
    void Update()
    {
        HungerText.text = Rock.GetComponent<RockController>().hunger.ToString();
    }
}
