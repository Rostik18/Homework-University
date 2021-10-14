package Patterns.Strategy;

public class AI {
    private AIStrategy aiStrategy;

    public void setAiStrategy(AIStrategy aiStrategy) {
        this.aiStrategy = aiStrategy;
    }

    public void doThing(){
        aiStrategy.doThing();
    }
}
