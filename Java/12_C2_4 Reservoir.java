import java.util.Scanner;

public class C2P4Reservoir {
	static int x,y,level,water;
	static int[][] stapel;
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		// Opgaven
		int opgaven = sc.nextInt();
		for (int o = 0; o < opgaven; o++) {

			// Stapel maken
			x = sc.nextInt();
			y = sc.nextInt();
			stapel = new int[x][y];
			water=0;
			int max=2*(x>y?x:y);
			int height=0;

			// Stapelen
			for (int i = 0; i < x; i++) {
				for (int j = 0; j < y; j++) {
					height=(stapel[i][j] = sc.nextInt())>height?stapel[i][j]:height;
				}
			}

			for (int k = 0; k <= height; k++) {
				level=k;
				//Check
				for (int i = 0; i < x; i++) {
					for (int j = 0; j < y; j++) {
						if(stapel[i][j]<k&&checkRand(i,j,max))water++;
					}
				}
			}
				System.out.println(water);
		}
		sc.close();
	}
	
	private static boolean checkRand(int a,int b,int max){
		max--;
		if(max<1)return true;
		if(stapel[a][b]>=level)return true;
		if(a>0&&b>0&&a<x-1&&b<y-1){
			return checkRand(a+1,b,max) && checkRand(a,b+1,max) && checkRand(a-1,b,max) && checkRand(a,b-1,max);
		}
		return false;
	}
}
