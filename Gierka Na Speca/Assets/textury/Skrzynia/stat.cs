using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stat : MonoBehaviour
{
	/*
	img type =  filled;
	fill method  horizontal;
	 /|\ jako health bar.
	 w player dodaj " 
	[SerializeField]        <-- do tego dodaj kod health img
	private stat health;   	" 
	[SerializeField]
	private float initValue;
	    w update(){} w graczu daj health.MyCurrentValue = 100; <- to zmieniaj teraz jak bedzie na + / - 
	    w Start(){}     health.Initialize(inithealth , inithealth);
		\|/ to przy poruszaniu dodaj to jest do debugowania
	if(Input.GetKeyDown(KeyCode.I))
	{
		health.MyCurrentValue -= 10;
	}
	if(Input.GetKeyDown(KeyCode.O))
	{
		health.MyCurrentValue += 10;
	}
	*/

	private Image content;
	private float currentFill;

	[SerializeField]
	private float lerpSpeed;

	public float MyMaxValue { get; set; }


	private float currentValue;

	public float MyCurrentValue
	{
		get
		{
			return currentValue;
		}

		set
		{
			if (value > MyMaxValue)
			{
				currentValue = MyMaxValue;
			}
			else if (value < 0)
			{
				currentValue = 0;
			}
			else
			{
				currentValue = value;
			}

			currentFill = currentValue / MyMaxValue;
		}

	}



	void Start()
	{
		content = GetComponent<Image>();
		MyMaxValue = 100;
		lerpSpeed = 1;

	}


	void Update()
	{
		if (currentFill != content.fillAmount)
		{
			content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpSpeed);
		}
	}

	public void Initialize(float currentValue, float maxValue)
	{
		MyMaxValue = maxValue;
		MyCurrentValue = currentValue;
	}

}