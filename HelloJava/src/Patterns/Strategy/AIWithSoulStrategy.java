package Patterns.Strategy;

public class AIWithSoulStrategy implements AIStrategy {
    @Override
    public void doThing() {
        System.out.println("    Yes, I'm behaving exactly like you, but am robot");
    }
}
