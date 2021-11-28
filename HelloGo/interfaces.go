package main

import "fmt"

type Vehicle interface {
	move()
}

type Car struct {
	speed int
}

type Aircraft struct {
	speed int
}

func (c Car) move() {
	fmt.Printf("Car moving with speed %v\n", c.speed)
}
func (a Aircraft) move() {
	fmt.Printf("Aircraft flying with speed %v\n", a.speed)
}

func main() {

	var tesla Vehicle = Car{100}
	var boing Vehicle = Aircraft{800}
	tesla.move()
	boing.move()
}
