package main

import "fmt"

func main() {

	defer finish()

	// woow complex numbers!
	var f complex64 = 1 + 2i
	var g complex64 = 2 - 5i

	fmt.Println(f / g)

	// foreach like
	numbers := generateRange(1, 30)
	for _, number := range numbers {
		fmt.Printf("\nCollatz row for %v:\n", number)
		collatzConjecture(number)
	}

	panic("Program killed")
}

func collatzConjecture(x int) (y int) {

	fmt.Printf("%v -> ", x)

	if x == 1 {
		return 1
	}

	if x%2 == 1 {
		return collatzConjecture(x*3 + 1)
	}
	if x%2 == 0 {
		return collatzConjecture(x / 2)
	}

	return 1
}

func generateRange(min, max int) []int {
	a := make([]int, max-min+1)
	for i := range a {
		a[i] = min + i
	}
	return a
}

func finish() {
	fmt.Println("\n\nLast breath of a program...")
}
