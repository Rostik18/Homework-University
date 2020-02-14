parent(mariya1, rostik).
parent(myron, rostik).
parent(mariya1, igor).
parent(myron, igor).
parent(mariya1, bohdan).
parent(myron, bohdan).

parent(ganna, mariya1).
parent(myhailo, mariya1).

parent(kateryna, myron).
parent(pavlo, myron).

parent(mariya2, yaryna).
parent(igor, yaryna).

parent(mariya3, olena).
parent(bohdan, olena).

age(rostik, 19).
age(igor, 34).
age(bohdan, 33).

age(mariya1, 55).
age(myron, 58).

age(pavlo, 90).

age(yaryna, 3).
age(olena, 11).

man(rostik).
man(myron).
man(igor).
man(bohdan).
man(myhailo).
man(pavlo).

woman(mariya1).
woman(mariya2).
woman(mariya3).
woman(ganna).
woman(kateryna).
woman(yaryna).
woman(olena).

ageDiff(A, B, Rez):- age(A, Age1), age(B, Age2), Rez is Age2 - Age1.
married(A, B):- parent(A, X), parent(B, X).

brothers(A, B):- parent(X, A), parent(X, B), man(A), man(B), A \= B.
sisters(A, B):- parent(X, A), parent(X, B), woman(A), woman(B), A \= B.

grandParent(A, B):- parent(X, B), parent(A, X).

cousin(A, B):- parent(X, A), parent(F, B), parent(T, F), parent(T, F), X \= F.

preParent(A, B):- parent(A, B).
preParent(A, B):- parent(A, X), preParent(X, B).

diadia(A, B):- parent(X, A), brothers(X, B).