package com.practice.StrategyDesignPattern.Model;

import com.practice.StrategyDesignPattern.Interface.IAlgorithm;

public class Strategy {
	public IAlgorithm _algorithm;
	
	public Strategy(IAlgorithm algorithm)
	{
		_algorithm = algorithm;
	}
	
	public void sortNumbers(int[] numbers)
	{
		_algorithm.sort(numbers);
	}
}
