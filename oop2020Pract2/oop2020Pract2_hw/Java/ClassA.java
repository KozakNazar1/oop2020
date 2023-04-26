package org.eom.oop;

public class ClassA{
    private int value;
	public ClassA(int value){
        this.value = value;
    }        
    public int getValue(){
        return value;
    }
    public void setValue(int value){
        this.value = value;
    }	
    public void print(){
        System.out.println(value);
    }
}
