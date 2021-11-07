Repositorio
	https://github.com/sdiazDAG/refactoring-golf.git

Hole1 a Hole2

1º)	Cambiar sentencia if en la linea 38 de 
		if (total.second == tax.second)
    	a
		if (!total.second.Equals(tax.second)) (Edición manual)
2º)	Pasar linea 39 
		return new Pair<int, String>(total.first - tax.first, first.second);
	a el final del método NetAmount (Edición manual)
3º)	Pasar la linea 44 
		throw new Incalculable();
	dentro de la sentencia if (Edición manual)
4º)	Eliminar else (Edición manual)

Total puntos ... 8 puntos
________________________________________________________________________________________________________________

Hole2 a Hole3

1º)	Rename de la clase Pair a Money (Edición con el IDE)
2º)	Rename propiedad first a value (Edición con el IDE)
3ª)	Rename propiedad second a currency (Edición con el IDE)
4º)	Eliminar <A,B> en la definición de la clase Money (Edición manual)
5º)	Replace tipo A por int en la clase Money (Edición con el IDE)
6º)	Replace tipo B por string en la clase Money (Edición con el IDE)
7º)	Replace Money<int, String> por Money en la clase TakeHomeCalculator (Edición con el IDE)

Total puntos ... 8 puntos

________________________________________________________________________________________________________________

Hole3 a Hole4

1º)	Extraer la linea 24 a 27 al método 
		private static void Plus(Money next, Money total) (Edición con el IDE)
2º)	Make method Non Static dentro de la clase Money   
		public void Plus(Money next) (Edición con el IDE)
3ª)	Change signature del método Plus 
		public Money Plus(Money other)(Edición con el IDE)
4º)	Añadir al método Plus que devuelva un tipo Money de la siguiente manera
		return new Money(value + other.value, other.currency); (Edición manual)
5º)	Cambiar la linea 24 de la clase TakeHomeCalculator 
		total.Plus(next);
	a
		total = total.Plus(next);	 (Edición manual)
6º)	Eliminar de la linea 26 a la 30 	(Edición manual)

Total puntos ... 9 puntos

________________________________________________________________________________________________________________

Hole4 a Hole5

1º)	Replace Constructor con Factory Method en la clase Money (Edición con el IDE)

2º)	Extraer la linea 30 a 33 al método 
		private static void Minus(Money total, Money tax) (Edición con el IDE)
3º)	Make method Non Static dentro de la clase Money   
		public void Minus(Money tax) (Edición con el IDE)
4ª)	Change signature del método Plus 
		public Money Minu(Money other) (Edición con el IDE)
5º)	Añadir al método Plus que devuelva un tipo Money de la siguiente manera
		return Create(value - other.value, currency); (Edición manual)
6º)	Eliminar la linea 32 de la clase TakeHomeCalculator 
		return Money.Create(total.value - tax.value, first.currency);  (Edición manual)
7º)	Cambiar la linea 30 
		total.Minus(tax);
	a
		return total.Minus(tax); (Edición manual)

Total puntos ... 10 puntos

