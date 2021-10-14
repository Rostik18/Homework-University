package Patterns.Strategy;

public class AIWithoutSoulAndWithHugePowerStrategy implements AIStrategy {
    @Override
    public void doThing() {
        System.out.println("    I'll kill all alive!!!");
    }
}
