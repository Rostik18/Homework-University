package Patterns.ChainOfResponsibility;

public class DistrictCouncil extends CivilServant {
    @Override
    public void resolveProblem(Problem problem, String description) {
        if(problem == Problem.REGIONAL){
            System.out.println("    District council resolving problem (" + description + ")!");
        }else {
            System.out.println("    District council can not resolve the problem. Delegating problem next");
            nextServant.resolveProblem(problem, description);
        }
    }
}