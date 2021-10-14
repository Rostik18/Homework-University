package Patterns.Singleton;

public class SingletonExample {

    public static void Execute() {
        System.out.println("Taking SimpleSingletonService instance in the first time");
        var instance = SimpleSingletonService.getInstance();
        System.out.println("Its id " + instance.getId());

        System.out.println("Taking SimpleSingletonService instance again");
        instance = SimpleSingletonService.getInstance();
        System.out.println("Its id " + instance.getId());

        System.out.println("Once more");
        instance = SimpleSingletonService.getInstance();
        System.out.println("Its id " + instance.getId());
    }
}
