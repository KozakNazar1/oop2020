namespace org.eom.oop{ // not necessarily
    
    class MainClass{
        static void Main(string[] args){
            System.Console.WriteLine("class and generic class");

            ClassA objectA = new ClassA(1);
            objectA.print();
            objectA = new ClassA(2);
            objectA.print();
       
            GenericClassA<int> intObjectA = 
                new GenericClassA<int>(1); // allowed(int is Int32)
            intObjectA.print();
            intObjectA = new GenericClassA<int>(2);
            intObjectA.print();

            GenericClassA<System.Int32> vInt32ObjectA =
                new GenericClassA<System.Int32>(1); // allowed    	
            vInt32ObjectA.print();
            vInt32ObjectA = new GenericClassA<System.Int32>(2);
            vInt32ObjectA.print();
        }
    }
}