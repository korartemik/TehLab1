class learn {
  def main() ={
    object BirdOperator extends Serializable {

      implicit class Pipe[A](a: A) {
        def |>[Z](f: A => Z): Z = f(a)
      }

      implicit class Pipe2[A, B](a: (A, B)) {
        def |>[Z](f: (A, B) => Z): Z = f.tupled(a)
      }

    }

    val getNumber: Int = 6

    def doubleNumber(a: Int): Int = a * 2

    def duplicate[A](a: A): (A, A) = (a, a)

    def add(a: Int, b: Int): Int = a + b

    val result1 = {
      val (a, b) = duplicate(doubleNumber(getNumber))
      add(a, b)
    }

    import BirdOperator._
    val result2 = getNumber |> doubleNumber |> duplicate |> add

    println(result1)
    println(result2)

  }
}
