sum(X, Rez):- X1 is X - 1, sum(X1, W), Rez is X + W.

sum(1, 1):- !.