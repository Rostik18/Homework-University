package rosty

  object Demo {

    def main(args: Array[String]) ={

      val numbers = List(2,4,1,3)

      for(numb <- numbers){
        println(s"square of $numb is ${doAction(numb, square)}")
        println(s"sum of $numb is ${doAction(numb, sum)}")
      }
    }

    def doAction(x: Int, f: Int => Int) = {
      f(x)
    }

    def square(x: Int) = {
      x*x
    }

    def sum(x: Int) = {
      x+x
    }
  }

