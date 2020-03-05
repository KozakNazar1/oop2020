namespace org.eom.oop{ // not necessarily
    
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
            System.Console.WriteLine(value);
        }
    }
}