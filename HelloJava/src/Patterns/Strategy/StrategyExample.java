package Patterns.Strategy;

public class StrategyExample {

    public static void Execute() {
        AI ai = new AI();
        ai.setAiStrategy(new AINowadaysStrategy());
        System.out.println("AI nowadays: ");
        ai.doThing();
        ai.setAiStrategy(new AIWithSoulStrategy());
        System.out.println("AI with soul: ");
        ai.doThing();
        ai.setAiStrategy(new AIWithoutSoulAndWithHugePowerStrategy());
        System.out.println("AI without soul: ");
        ai.doThing();
    }
}
