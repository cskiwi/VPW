import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;

public class C2P3Quilt {
	private static HashMap<Integer, Character> stuff = new HashMap<Integer, Character>();

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		// Decl
		String bevel;
		boolean doorgaan = true;
		String[] pStr;
		int[] pInt;
		ArrayList<Integer>[] volgorde;

		// Chars
		stuff.put(0, '+');
		stuff.put(1, '/');
		stuff.put(2, '\\');
		stuff.put(3, '-');
		stuff.put(4, '|');

		// Opgaven maken
		int opgaven = sc.nextInt();
		for (int i = 0; i < opgaven; i++) {
			// Patronen inlezen
			int patronen = sc.nextInt();
			pStr = new String[patronen];
			pInt = new int[patronen];
			for (int p = 0; p < patronen; p++) {
				pStr[p] = sc.next() + sc.next();
				pInt[p] = toInt(pStr[0]);
			}
			// Bevelen inlezen
			int bevelen = sc.nextInt();
			for (int b = 0; b < bevelen && doorgaan; b++) {
				bevel = sc.next();
				if (bevel.equals("stop")) {
					doorgaan = false;
				} else if (bevel.equals("teken")) {

					System.out.println();
				} else if (bevel.equals("naai")) {

					System.out.println();
				} else if (bevel.equals("draai")) {

					System.out.println();
				} else if (isNumeric(bevel)) {

					System.out.println();
				}

			}
		}
		sc.close();
	}

	public static boolean isNumeric(String str) {
		for (char c : str.toCharArray()) {
			if (!Character.isDigit(c))
				return false;
		}
		return true;
	}

	private static int toInt(String s) {
		int ret = 0;
		for (char c : s.toCharArray()) {
			ret *= 5;
			ret += stuff.get(c);
		}
		return ret;
	}
}