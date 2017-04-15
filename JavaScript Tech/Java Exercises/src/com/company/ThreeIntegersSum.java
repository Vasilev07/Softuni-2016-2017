package com.company;


import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        int firstNumber = scan.nextInt();
        int secondNumber = scan.nextInt();
        int thirdNumber = scan.nextInt();
        if (!checkNumbers(firstNumber,secondNumber,thirdNumber))
    }

    public static boolean checkNumbers(int num1, int num2, int sum){
        if (num1 + num2 != sum){
            return false;
        }
        if(num1 <= num2){
            System.out.printf("%d + %d = %d\n",num1, num2, sum);
        }else{
            System.out.printf("%d + %d = %d\n",num2,num1,sum);
        }
        return true;
    }
}
