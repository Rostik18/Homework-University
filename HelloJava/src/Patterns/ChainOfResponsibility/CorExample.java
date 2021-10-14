package Patterns.ChainOfResponsibility;

public class CorExample {

    public static void Execute() {

        CivilServant civilServant = new VillageCouncil();
        civilServant.addMoreCompetent(new DistrictCouncil())
                .addMoreCompetent(new President());

        System.out.println("Global problem: Country in a war");
        civilServant.resolveProblem(Problem.GLOBAL, "Country in a war");
        System.out.println("Unknown problem: The meteorite falls to the earth");
        civilServant.resolveProblem(Problem.UNKNOWN, "The meteorite falls to the earth");
    }
}
