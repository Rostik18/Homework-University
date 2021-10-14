package Patterns.ChainOfResponsibility;

public abstract class CivilServant {
    protected CivilServant nextServant;

    public CivilServant addMoreCompetent(CivilServant civilServant){
        this.nextServant = civilServant;
        return civilServant;
    }

    public abstract void resolveProblem(Problem problem, String description);
}
