import java.util.Arrays;
import java.util.Scanner;


public class C2P5Woorden {
	static String[] grepen;
	static int max;
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		// Opgaven
		int opgaven = sc.nextInt();
		for (int o = 0; o < opgaven; o++) {
			
			//input
			int aantalWoorden = sc.nextInt();
			String[] woorden=new String[aantalWoorden];
			for (int w = 0; w < aantalWoorden; w++) {
				woorden[w]=sc.next().toLowerCase();
			}
			int aantalGrepen = sc.nextInt();
			grepen=new String[aantalGrepen];
			max=0;
			for (int g = 0; g < aantalGrepen; g++) {
				grepen[g]=sc.next().toLowerCase();
				max=max>grepen[g].length()?max:grepen[g].length();
			}
			System.out.println(max);
			for (int w = 0; w < aantalWoorden; w++) {
				System.out.println(woorden[w]);
			}
			for (int g = 0; g < aantalGrepen; g++) {
				System.out.println(grepen[g]);
			}

			for (int w = 0; w < aantalWoorden; w++) {
				System.out.println(solve(woorden[w]));
			}
		}
		sc.close();
	}

	private static String solve(String rest) {
		if(rest.length()==0)return null;
		for (int i = 0;i < max && i< rest.length(); i++) {
			String doing=rest.substring(0,i+1);
			int p=Arrays.asList(grepen).indexOf(doing);
			if(p!=-1){
				String todo=rest.substring(i+1);
				String solved=solve(todo);
				System.out.println("todo "+todo);
				if(solved!=null){
					System.out.println("solved "+solved);
					return doing+"-"+solved;
				}
			}
		}
		
		return null;
	}
}
