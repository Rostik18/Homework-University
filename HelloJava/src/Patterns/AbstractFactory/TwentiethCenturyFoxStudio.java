package Patterns.AbstractFactory;

import Patterns.AbstractFactory.Products.*;

public class TwentiethCenturyFoxStudio extends Studio {

    @Override
    public HorrorFilm makeHorror() {
        return new AlienFH();
    }

    @Override
    public DramaFilm makeDrama() {
        return new BohemianRhapsodyFD();
    }

    @Override
    public ThrillerFilm makeThriller() {
        return new BadTimesAtElRoyaleFT();
    }
}
