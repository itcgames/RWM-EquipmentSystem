﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setupItem : MonoBehaviour
{
    
    public int itemAmount;
    public string itemName;
    private int amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = itemAmount;
        GetComponentInChildren<Text>().text = itemName;
        GetComponentInChildren<Text>().GetComponentInChildren<Text>().text =  itemName +" x " + amount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getAmount()
    {
        return amount;
    }

   public void changeAmount(int t_amount)
    {
      amount =  amount - t_amount;
    }
}
