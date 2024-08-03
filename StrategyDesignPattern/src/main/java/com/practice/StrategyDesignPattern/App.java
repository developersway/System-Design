package com.practice.StrategyDesignPattern;

import java.util.Arrays;

import com.practice.StrategyDesignPattern.Model.*;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        Strategy strat = new Strategy(new BubbleSort());
        int[] numbers = {22, 34,323 ,453 };
        
        strat.sortNumbers(numbers);
        System.out.println("Sorted Numbers " + Arrays.toString(numbers));
    }
}
