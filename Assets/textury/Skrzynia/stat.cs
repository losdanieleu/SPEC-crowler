﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stat : MonoBehaviour
{
	public Slider slider;
	
	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;
	}
	
	public void SetHealth(int health)
	{
		slider.value = health;
	}
	
	private void Update()
	{
		
	}

}