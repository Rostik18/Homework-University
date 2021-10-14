package Patterns.AbstractFactory;

import Patterns.AbstractFactory.Products.*;

public abstract class Studio {
    public abstract HorrorFilm makeHorror();
    public abstract DramaFilm makeDrama();
    public abstract ThrillerFilm makeThriller();
}
