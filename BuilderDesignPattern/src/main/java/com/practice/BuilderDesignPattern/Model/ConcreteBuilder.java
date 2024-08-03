package com.practice.BuilderDesignPattern.Model;

import com.practice.BuilderDesignPattern.Interface.IBuilder;

public class ConcreteBuilder implements IBuilder{
	
	public House house;
	
	public ConcreteBuilder()
	{
		this.house = new House();
	}
	@Override
	public void buildFoundation() {
		house.setFoundation("Concrete and Bricks - ");		
	}

	@Override
	public void buildStructutre() {
		house.setStructure("Wooden Structure - ");
		
	}

	@Override
	public void buildRooftop() {
		house.setRoof("Metal Roof - ");
		
	}

	@Override
	public void buildInterior() {
		house.setInterior("Dry Interior - ");
		
	}

	@Override
	public House getHouse() {
		return house;
	}
	
}
