package com.practice.StrategyDesignPattern.Model;

import com.practice.StrategyDesignPattern.Interface.IAlgorithm;

public class BubbleSort implements IAlgorithm{

	@Override
	public void sort(int[] numbers) {
		int n = numbers.length;
        for (int i = 0; i < n-1; i++) {
            for (int j = 0; j < n-i-1; j++) {
                if (numbers[j] > numbers[j+1]) {
                    int temp = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = temp;
                }
            }
        }
        System.out.println("Sorted using Bubble Sort");
	}

}
