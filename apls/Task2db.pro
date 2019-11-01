cat(black).
cat(white).
cat(red).

flat(1).
flat(2).
flat(3).

livesIn(Flat, Cat):- flat(Flat), cat(Cat), Flat = 2, not(Cat= black).

livesIn(Flat, Cat):- flat(Flat), cat(Cat), Flat = 1, not(Cat= black).

livesIn(Flat, Cat):- flat(Flat), cat(Cat), Cat= white, not(Flat = 1), not( livesIn(.