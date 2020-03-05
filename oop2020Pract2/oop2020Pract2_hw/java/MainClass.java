package org.eom.oop;

public class MainClass 
{
    public static void main( String[] args )
    {
        System.out.println( "class and generic class" );   
        
        ClassA objectA = new ClassA(1); 
        objectA.print();
        objectA = new ClassA(2); 
        objectA.print();         
        
    	// GenericClassA<int> intObjectA = 
        //     new GenericClassA<int>(1); // not allowed
        // intObjectA.print();
        // intObjectA = new GenericClassA<Integer>(2);
        // intObjectA.print(); 
    	
        GenericClassA<Integer> integerObjectA = 
        		new GenericClassA<Integer>(1); // allowed
    	integerObjectA.print();
    	integerObjectA = new GenericClassA<Integer>(2);
    	integerObjectA.print();    	
    }
}