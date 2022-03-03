public class Test {
    private native int Sum(int a, int b);
    static {
        System.load("C:/Users/Артём/source/repos/Dll2/x64/Debug/Dll2.dll");
    }
    public static void main(String[] args) {
       Test test = new Test();
       System.out.println(test.Sum(10,7));
    }


}
