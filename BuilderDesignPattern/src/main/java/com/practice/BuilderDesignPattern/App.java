package com.practice.BuilderDesignPattern;

import com.practice.BuilderDesignPattern.Model.*;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        ConcreteBuilder concrete = new ConcreteBuilder();
        Director dir = new Director(concrete);
        
        House house = dir.build();
        house.HouseComponent();
    }
}
