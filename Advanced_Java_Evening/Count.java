package com.company;
import java.io.File;
public class Count {
    public static void main(String args[]){
        File dir = new File("C:\\Users\\santosh\\Pictures\\Maven");
        int fileCount=dir.list().length;
        System.out.println("No. of files :"+ fileCount);
    }
    
}
