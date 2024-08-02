package com.practice.decoratordesignpattern.Model;

import com.practice.decoratordesignpattern.Interface.Coffee;

public class MilkCoffee extends DecoratedCoffee{

	public MilkCoffee(Coffee coffee) {
		super(coffee);
	}
	
	@Override
	public String getDesc()
	{
		return coffeeReference.getDesc() + ", Milk";
	}
	
	@Override
	public int getPrice()
	{
		return coffeeReference.getPrice() + 5;
	}

}
