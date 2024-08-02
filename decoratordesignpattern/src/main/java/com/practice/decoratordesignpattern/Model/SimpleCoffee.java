package com.practice.decoratordesignpattern.Model;

import com.practice.decoratordesignpattern.Interface.*;

public class SimpleCoffee implements Coffee{
	
	
	@Override
	public String getDesc() {
		return "Simple Coffee";
	}

	@Override
	public int getPrice() {
		return 10;
	}

}
