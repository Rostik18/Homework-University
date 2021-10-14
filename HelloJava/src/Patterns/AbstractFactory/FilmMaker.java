package Patterns.AbstractFactory;

import Patterns.AbstractFactory.Products.*;

public class FilmMaker {

    private HorrorFilm horrorFilm;
    private DramaFilm dramaFilm;
    private ThrillerFilm thrillerFilm;

    public FilmMaker(Studio studio)
    {
        horrorFilm = studio.makeHorror();
        dramaFilm = studio.makeDrama();
        thrillerFilm = studio.makeThriller();
    }

    public void watchHorror()
    {
        System.out.println("    You are watching " + horrorFilm.title);
    }

    public void watchDrama()
    {
        System.out.println("    You are watching " + dramaFilm.title);
    }

    public void watchThriller()
    {
        System.out.println("    You are watching " + thrillerFilm.title);
    }
}
