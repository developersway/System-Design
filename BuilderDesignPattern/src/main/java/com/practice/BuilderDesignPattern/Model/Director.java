package com.practice.BuilderDesignPattern.Model;

import com.practice.BuilderDesignPattern.Interface.IBuilder;

public class Director {
	public IBuilder _builder;
	
	public Director(IBuilder builder)
	{
		_builder = builder;
	}
	
	public House build()
	{
		_builder.buildFoundation();
		_builder.buildStructutre();
		_builder.buildRooftop();
		_builder.buildInterior();
		return _builder.getHouse();
	}
}
