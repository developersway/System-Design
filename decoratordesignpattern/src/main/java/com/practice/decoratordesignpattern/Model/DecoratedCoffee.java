package com.practice.decoratordesignpattern.Model;

import com.practice.decoratordesignpattern.Interface.Coffee;

public class DecoratedCoffee implements Coffee{
	
	protected Coffee coffeeReference;
	
	public DecoratedCoffee(Coffee coffee)
	{
		this.coffeeReference = coffee;
	}
	
	@Override
	public String getDesc() {
		return this.coffeeReference.getDesc();
	}

	@Override
	public int getPrice() {
		return this.coffeeReference.getPrice();
	}
	
}
