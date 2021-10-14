package Patterns.Strategy;

public class AINowadaysStrategy implements AIStrategy {
    @Override
    public void doThing() {
        System.out.println("    I am Alice. Have I can help you?");
    }
}
