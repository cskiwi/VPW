import java.util.Scanner;

class Main {
    public static void main(String[] args) {
    	Scanner sc=new Scanner(System.in);
        int invoer,min=0,max=0,nummers,opgaven = sc.nextInt();
        String output="";
        for(int i=0;i<opgaven;i++){
        	nummers = sc.nextInt();
            for(int n=0;n<nummers;n++){
            	invoer = sc.nextInt();
            	if(n==0){min=max=invoer;}
            	min=min>invoer?invoer:min;
            	max=max<invoer?invoer:max;
            }
            output+=min+" "+max;
            if(i<opgaven-1)
            	output+="\n";
        }
        System.out.print(output);
        sc.close();
    }
}
