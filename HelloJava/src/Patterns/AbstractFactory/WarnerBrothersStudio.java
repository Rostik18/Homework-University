package Patterns.AbstractFactory;

import Patterns.AbstractFactory.Products.*;

public class WarnerBrothersStudio extends Studio {

    @Override
    public HorrorFilm makeHorror() {
        return new TheShiningWH();
    }

    @Override
    public DramaFilm makeDrama() {
        return new JokerWD();
    }

    @Override
    public ThrillerFilm makeThriller() {
        return new InceptionWT();
    }
}