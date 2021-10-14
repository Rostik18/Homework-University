package Patterns.ChainOfResponsibility;

public class VillageCouncil extends CivilServant {
    @Override
    public void resolveProblem(Problem problem, String description) {
        if(problem == Problem.LOCAL){
            System.out.println("    Village council resolving problem (" + description + ")!");
        }else {
            System.out.println("    Village council can not resolve the problem. Delegating problem next");
            nextServant.resolveProblem(problem, description);
        }
    }
}
