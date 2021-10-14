package Patterns.AbstractFactory;

import Patterns.ChainOfResponsibility.*;

public class AbstractFactoryExample {
    public static void Execute() {

        System.out.println("20th Century Fox making movies. Let's watch what they did:");
        FilmMaker fox = new FilmMaker(new TwentiethCenturyFoxStudio());
        System.out.println("  20th Century Fox horror:");
        fox.watchHorror();
        System.out.println("  20th Century Fox drama:");
        fox.watchDrama();
        System.out.println("  20th Century Fox thriller:");
        fox.watchThriller();

        System.out.println("Now Warner Brothers turn:");
        FilmMaker wb = new FilmMaker(new WarnerBrothersStudio());
        System.out.println("  Warner Brothers horror:");
        wb.watchHorror();
        System.out.println("  Warner Brothers drama:");
        wb.watchDrama();
        System.out.println("  Warner Brothers thriller:");
        wb.watchThriller();
    }
}
