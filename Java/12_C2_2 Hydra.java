import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class C2P2Hydra {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int aantalBomen =1;// sc.nextInt();
		int punten,gen,knippen,totaalknippen=0;
		String stamtak, parent, deze, child;
		for (int i = 0; i < aantalBomen; i++) {// Voor elke boom
			punten = 0;
			int aantalVertak = sc.nextInt();
			if (!sc.next().equals("stam"))
				System.out.println("Probleem");
			int stamTakken = sc.nextInt();

			Map<String, String> map = new HashMap<String, String>();
			Map<String, Integer> ptn = new HashMap<String, Integer>();
			for (int s = 0; s < stamTakken; s++) {// Voor elke stamtak
				stamtak = sc.next();
				if(!stamtak.equals("*")){
					map.put(stamtak, stamtak);
					ptn.put(stamtak, 1);
					System.out.println("put");
				}
			}
			System.out.println("sdf");

			for (int t = 0; t < aantalVertak; t++) {// Voor elke tak
				knippen=0;
				deze = sc.next();
				parent = map.get(deze);
				gen=0;
				while(deze!=parent){
					gen++;
					parent = map.get(deze);
				}
				if(gen==0){}
				int subTakken = sc.nextInt();
				for (int s = 0; s < subTakken; s++) {// Voor elke stamtak
					stamtak = sc.next();
				}
				String name = sc.next();
				punten++;
				System.out.println(punten);
			}
		}
		sc.close();
	}
}