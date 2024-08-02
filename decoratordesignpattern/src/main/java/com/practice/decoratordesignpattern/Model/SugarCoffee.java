package com.practice.decoratordesignpattern.Model;

import com.practice.decoratordesignpattern.Interface.Coffee;

public class SugarCoffee extends DecoratedCoffee{

	public SugarCoffee(Coffee coffee) {
		super(coffee);
	}
	
	@Override
	public String getDesc()
	{
		return coffeeReference.getDesc() + ", Sugar";
	}
	
	@Override
	public int getPrice()
	{
		return coffeeReference.getPrice() + 10;
	}

}
