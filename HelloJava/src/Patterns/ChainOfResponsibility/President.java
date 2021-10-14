package Patterns.ChainOfResponsibility;

public class President extends CivilServant {
    @Override
    public void resolveProblem(Problem problem, String description) {
        if(problem == Problem.GLOBAL){
            System.out.println("    President resolving problem (" + description + ")!");
        }else {
            System.out.println("    Even President is powerless here. Call Bruce Willis");
        }
    }
}
