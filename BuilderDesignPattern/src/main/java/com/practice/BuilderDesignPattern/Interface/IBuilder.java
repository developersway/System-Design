package com.practice.BuilderDesignPattern.Interface;

import com.practice.BuilderDesignPattern.Model.House;

public interface IBuilder {
	public void buildFoundation();
	public void buildStructutre();
	public void buildRooftop();
	public void buildInterior();
	
	public House getHouse();
}
