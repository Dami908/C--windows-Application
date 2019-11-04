package emmanuel_Ajayi_sec008_exercise2;

import java.security.SecureRandom;
import java.util.Scanner;

public class Lotto {
private int[] numbers= {0,0,0};
private int total;
private static int count = 0;
Scanner input=new Scanner(System.in);

public int[] getNumbers() {
	return numbers;
}
public int getTotal() {
	return total;
}

public Lotto() {

	final SecureRandom RandomNumbers=new SecureRandom();
	int i=0;
	
	while(i<3) {
		numbers[i]=RandomNumbers.nextInt(9);
		numbers[i]+=1;
		total+=numbers[i];
		//System.out.println(numbers[i]);
		i++;
	}
}
public void simulatelotto() {
	Scanner input=new Scanner(System.in);
	while(count<5) {
		Lotto test2=new Lotto();
		int guess;
		count++;
		System.out.println("\nWelcome to lotto");
		do {
			System.out.println("Pick a number between 3 and 27");
			guess=input.nextInt();
		} while (guess < 3 || guess > 27);

		if(guess==test2.getTotal()) {
			System.out.println("Congratulations you Win");
			break;
		}
		else if(count<=5) {
			System.out.println("Better Luck next time");
			System.out.println("Your lotto winning number was "+test2.getTotal());
			
		}
	}
	 if(count>=5) {
		System.out.println("\nYou lose, Computer wins");
	 }
	 input.close();
}
public static int getCount() {
	return count;
}

}

