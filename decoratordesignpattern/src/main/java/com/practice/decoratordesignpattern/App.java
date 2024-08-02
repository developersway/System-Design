package com.practice.decoratordesignpattern;

import com.practice.decoratordesignpattern.Interface.*;
import com.practice.decoratordesignpattern.Model.*;
public class App 
{
    public static void main( String[] args )
    {
        Coffee coffee = new SimpleCoffee();
        
        coffee = new SugarCoffee(coffee);
        coffee = new MilkCoffee(coffee);
        
        System.out.println(coffee.getDesc());
        System.out.println(coffee.getPrice());
    }
}
