import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Main {
	static String[] lower;
	static String[] normal;
	static List<String> check;
	static int max;

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		// Opgaven
		int opgaven = sc.nextInt();
		String output = "";
		for (int o = 0; o < opgaven; o++) {

			// input
			int aantalWoorden = sc.nextInt();
			String[] woorden = new String[aantalWoorden];
			for (int w = 0; w < aantalWoorden; w++) {
				woorden[w] = sc.next().toLowerCase();
			}
			int aantalGrepen = sc.nextInt();
			lower = new String[aantalGrepen];
			normal = new String[aantalGrepen];
			max = 0;
			for (int g = 0; g < aantalGrepen; g++) {
				normal[g] = sc.next();
				lower[g] = normal[g].toLowerCase();
				max = max > lower[g].length() ? max : lower[g].length();
			}
			check=Arrays.asList(lower);
			for (int w = 0; w < aantalWoorden; w++) {
				String temp= solve(woorden[w]);
				if(temp==null)output+="nee";
				else{output+=temp;}
				if(o<opgaven-1||w<aantalWoorden-1)output+="\n";
			}
		}
		System.out.print(output);
		sc.close();
	}

	private static String solve(String rest) {
		int len = rest.length();
		if (len == 0)
			return "";
		for (int i = 0; i < max && i < len; i++) {
			String doing = rest.substring(0, i + 1);
			int p = check.indexOf(doing);
			if (p != -1) {
				String todo = rest.substring(i + 1);
				String solved = solve(todo);
				if (solved != null) {
					if (solved.length() == 0)
						return normal[p];
					return normal[p] + "-" + solved;
				}
			}
		}

		return null;
	}
}
