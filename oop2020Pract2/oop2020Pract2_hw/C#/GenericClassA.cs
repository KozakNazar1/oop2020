namespace org.eom.oop{ // not necessarily
    
    public class GenericClassA<T>{
        private T value;
        public GenericClassA(T value){
            this.value = value;
        }
        public T getValue(){
            return value;
        }
        public void setValue(T value){
            this.value = value;
        }
        public void print(){
            System.Console.WriteLine(value);
        }
    }
}
