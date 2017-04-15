package com.company;

import java.util.Scanner;


public class SumTwoNumbers {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        double firstNumber = scan.nextDouble();
        double secondNumber = scan.nextDouble();
        double result = firstNumber + secondNumber;
        System.out.printf("Sum = %.2f", result);
    }
}
