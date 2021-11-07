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

Total puntos .... 4 puntos