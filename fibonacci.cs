public static void {

	int[] fib_array = new int[40]
	fib_array[0] = 1;
	fib_array[1] = 1;


	for(int i =2; i < 40; i++){
		
		fib_array[i] = fib_array[i-2] + fib_array[i-1];
		
		
	}
	
	fib_array.ToList().ForEach(Console.WriteLine(i.toString()));
	

}

