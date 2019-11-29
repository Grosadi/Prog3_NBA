/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.util.Random;

/**
 *
 * @author hp EliteBook
 */


public class Team {
    
    static Random r = new Random();
    
    String Name;
    int Percentage;

    public String getName() {
        return Name;
    }

    public void setName(String Name) {
        this.Name = Name;
    }

    public int getPercentage() {
        return Percentage;
    }

    public void setPercentage(int Percentage) {
        this.Percentage = Percentage;
    }
    

    public Team(String Name) {
        this.Name = Name;
        this.Percentage = r.nextInt(90);
    }

    
    
}
