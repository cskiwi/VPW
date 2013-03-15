import java.util.Scanner;

public class C2P1Cijfer {
    public static void main(String[] args) {
    	Scanner sc=new Scanner(System.in);
        int targetindex,numbers = sc.nextInt();
        for(int i=0;i<numbers;i++){
        	targetindex = sc.nextInt();
            int n = 0;
            int magic = 0, nextmagic = 1;
	        while (nextmagic <= targetindex && nextmagic > magic) {
	            n++;
	            magic = nextmagic;
	            nextmagic += n * 9 * (int)Math.pow(10, n - 1);
	        }
	        System.out.println(Integer.toString(((int)Math.pow(10, n - 1) + ((targetindex - magic) / n)))
	        		.charAt((targetindex - magic)%n));
        }
        sc.close();
    }
}